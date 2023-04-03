using DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL.Model
{
    public class DB : IdentityDbContext<UserApp>
    {

        public DB(DbContextOptions<DB> options) : base(options)
        {

        }

        public DB()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=185.55.224.22;Initial Catalog=repairte_Repair123;Persist Security Info=True;User ID=repairte_admin;Password=qw@13795!");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> users { set; get; }
        public DbSet<Order> orders { set; get; }
        public DbSet<Contact> contacts { set; get; }
        public DbSet<User_Order> user_Orders { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.User__ID);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Order__ID);
            });
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.Contact_ID);
            });
            modelBuilder.Entity<User_Order>(entity =>
            {
                entity.HasKey(e => e.User_Order_ID);
            });
        }
    }
}
