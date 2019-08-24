using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using Microsoft.AspNetCore.Http;
using Models;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        private MyDbContext dbContext;
        public HomeController(MyDbContext Context)
        {
            this.dbContext = Context;
        }
        public IActionResult Index(bool Error, bool Register)
        {
            // if (Get("username") != null)
            // {
            //     var user = dbContext.Users.FirstOrDefault(x => x.Username == Get("username"));
            //     ViewBag.username = user.Username;
            // }
            if (Error == true)
            {
                ViewBag.Error = true;
            }
            if (Register == true)
            {
                ViewBag.Register = true;
            }
            if (Register == false)
            {
                ViewBag.Register = false;
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password, string save)
        {
            try
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    var user = new Users(username, password);
                    user = dbContext.Users.FirstOrDefault(x => x.Username == username);
                    if (user == null)
                    {
                        HttpContext.Session.SetString("logged", "false");
                        return Redirect("/?Error=" + true);
                    }
                    if (VerifyMd5Hash(md5Hash, password, user.Userpwd))
                    {
                        HttpContext.Session.SetString("logged", "true");
                        HttpContext.Session.SetInt32("Id", user.User_Id);
                        return Redirect("/Home/Home/?logged=" + true + "&Id=" + user.User_Id);
                    }
                    else
                    {
                        HttpContext.Session.SetString("logged", "false");
                        return Redirect("/?Error=" + true);
                    }
                }
            }
            catch (System.Exception)
            {
                HttpContext.Session.SetString("logged", "false");
                return Redirect("/?Error=" + true);
            }
            // if (save == "on")
            // {
            //     ViewBag.un = username;
            //     ViewBag.pw = password;
            // }
            // else
            // {
            //     ViewBag.un = null;
            //     ViewBag.pw = null;
            // }
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            // Remove("username");
            return Redirect("/");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // [HttpPost]
        // public void Set(string key, string value, int? expireTime)
        // {
        //     CookieOptions option = new CookieOptions();
        //     if (expireTime.HasValue)
        //         option.Expires = DateTime.Now.AddHours(expireTime.Value);
        //     else
        //         option.Expires = DateTime.Now.AddMilliseconds(10);
        //     Response.Cookies.Append(key, value, option);
        // }
        // public string Get(string key)
        // {
        //     return Request.Cookies[key];
        // }
        // public void Remove(string key)
        // {
        //     Response.Cookies.Delete(key);
        // }

        [HttpGet]
        public IActionResult Home(bool logged, int? Id, bool sendmail)
        {
            Id = HttpContext.Session.GetInt32("Id");
            if (logged == true)
            {
                var user = dbContext.Users.FirstOrDefault(x => x.User_Id == Id);
                ViewBag.Username = user.Username.ToUpper();
                List<Mail> ListMail = new List<Mail>();
                List<Users> ListUser = new List<Users>();
                List<MailDetails> SI = dbContext.MailDetails.FromSql(@"select * from maildetails where Sender_Id = " + Id + ";").ToList();
                List<MailDetails> RI = dbContext.MailDetails.FromSql(@"select * from maildetails where Receiver_Id = " + Id + ";").ToList();
                foreach (var item in SI)
                {
                    var listMailSend = dbContext.Mail.FirstOrDefault(x => x.Mail_Id == item.Mail_Id);
                    var ListReceiver = dbContext.Users.FirstOrDefault(x => x.User_Id == item.Receiver_Id);
                    ListMail.Add(listMailSend);
                    ListUser.Add(ListReceiver);
                }
                foreach (var item in RI)
                {
                    var listMailReceiver = dbContext.Mail.FirstOrDefault(x => x.Mail_Id == item.Mail_Id);
                    var ListSender = dbContext.Users.FirstOrDefault(x => x.User_Id == item.Sender_Id);
                    ListMail.Add(listMailReceiver);
                    ListUser.Add(ListSender);
                }
                ViewBag.ListMailSend = SI;
                ViewBag.ListMailReceiver = RI;
            }
            return View();
        }
        static string GetMd5Hash(MD5 md5Hash, string password)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        static bool VerifyMd5Hash(MD5 md5Hash, string password, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, password);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public IActionResult Home(string receiver, string title, string content)
        {
            var userReceiver = new Users(receiver);
            userReceiver = dbContext.Users.FirstOrDefault(x => x.Username == receiver);
            int? id = HttpContext.Session.GetInt32("Id");
            var userSend = dbContext.Users.FirstOrDefault(x => x.User_Id == id);
            if (userSend != null && userReceiver != null)
            {
                var mail = new Mail();
                var md = new MailDetails();
                md.Sender_Id = userSend.User_Id;
                md.Receiver_Id = userReceiver.User_Id;
                mail.Title = title;
                mail.Content = content;
                md.Mail = mail;
                dbContext.Add(md);
                dbContext.SaveChanges();
                HttpContext.Session.SetString("sendmail", "true");
                return Redirect("/Home/Home/?logged=" + true + "&Id=" + id + "/?sendmail=" + true);
            }
            else
            {
                HttpContext.Session.SetString("sendmail", "false");
                return Redirect("/Home/Home/?logged=" + true + "&Id=" + id + "/?sendmail=" + false);
            }
        }
    }
}
