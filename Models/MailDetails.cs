using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Models
{
    public class MailDetails
    {
        public int MailDetails_Id { get; set; }
        public int Mail_Id { get; set; }
        public int? Sender_Id { get; set; }
        public int Remove { get; set; }
        public int Receiver_Id { get; set; }
        [ForeignKey("Sender_Id")]
        public virtual Users Sender { get; set; }
        [ForeignKey("Receiver_Id")]
        public virtual Users Receiver { get; set; }
        public Mail Mail { get; set; }

        public MailDetails() { }
    }
}