using System;
using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Mail> Mail { get; set; }
        public DbSet<MailDetails> MailDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;uid=root;pwd=Hanhphuc1;database=DemoMVC");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(x => x.User_Id);
                entity.Property(x => x.Username);
                entity.Property(x => x.Userpwd);
            });
            modelBuilder.Entity<Mail>(entity =>
            {
                entity.HasKey(x => x.Mail_Id);
                entity.Property(x => x.Title);
                entity.Property(x => x.Content);
                entity.Property(x => x.Time);
            });
            modelBuilder.Entity<MailDetails>(entity =>
            {
                entity.HasKey(md => md.MailDetails_Id);
                entity.Property(md => md.Remove);
                entity.HasOne<Mail>(md => md.Mail).WithMany().HasForeignKey(md => md.Mail_Id);
            });
        }
    }
}