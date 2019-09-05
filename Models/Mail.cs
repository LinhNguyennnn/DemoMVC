using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Models
{
    public class Mail
    {
        public int Mail_Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public Mail() { }
    }
}