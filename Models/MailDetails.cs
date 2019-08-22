using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Models
{
    public class MailDetails
    {
        public int Mail_Detals_Id { get; set; }
        public int Mail_Id { get; set; }
        public int MailSend_Id { get; set; }
        public Users Users { get; set; }
        public Mail Mail { get; set; }

        public MailDetails() { }
    }
}