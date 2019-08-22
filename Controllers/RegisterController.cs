using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using Microsoft.AspNetCore.Http;
using Models;
using System.Text;
using System.Security.Cryptography;

namespace DemoMVC.Controllers
{
    public class RegisterController : Controller
    {
        private MyDbContext dbContext;
        public RegisterController(MyDbContext Context)
        {
            this.dbContext = Context;
            Context.Database.EnsureCreated();
        }
        [HttpPost]
        public IActionResult Register(string username, string password)
        {
            var user = new Users(username, password);
            user = dbContext.Users.FirstOrDefault(x => x.Username == username);
            if (user == null)
            {
                string hash;
                using (MD5 md5Hash = MD5.Create())
                {
                    hash = GetMd5Hash(md5Hash, password);
                }
                var user1 = new Users(username, password);
                user1.Username = username;
                user1.Userpwd = hash;
                dbContext.Add(user1);
                dbContext.SaveChanges();
                HttpContext.Session.SetString("Register", "true");
                return Redirect("/?Register=" + true + "&Id=" + user1.User_Id);
            }
            else
            {
                HttpContext.Session.SetString("Register", "false");
                return Redirect("/?Register=" + false);
            }
        }
        public IActionResult Register()
        {
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
    }
}