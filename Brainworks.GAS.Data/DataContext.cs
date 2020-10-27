using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BrainWorks.GAS.Data;
using Microsoft.EntityFrameworkCore;

namespace BrainWorks.GAS.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            string connectionString = "Data Source=DESKTOP-4QP868O\\SQLEXPRESS;Initial Catalog=BrainWork;Integrated Security=True";

            OptionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //User Registration
            modelBuilder.Entity<User>().Property(b => b.UserName).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Password).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.FirstName).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.LastName).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Gender).HasColumnType("varchar(50)");
            modelBuilder.Entity<User>().Property(b => b.DOB).HasColumnType("DateTime").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Address).HasColumnType("varchar(100)");
            modelBuilder.Entity<User>().Property(b => b.CityId).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.DistrictId).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.StateId).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Pincode).HasColumnType("varchar(6)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Mobile).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Email).HasColumnType("varchar(50)");
        }
    }
}
