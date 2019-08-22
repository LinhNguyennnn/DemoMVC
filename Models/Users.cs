using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Models
{
    public class Users
    {
        public int User_Id { get; set; }
        public string Username { get; set; }
        public string Userpwd { get; set; }

        public Users(string username, string userpwd)
        {
            this.Username = username;
            this.Userpwd = userpwd;
        }
        public Users(string username)
        {
            this.Username = username;
        }
    }
}