using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BrainWorks.GAS.Data;
using Microsoft.EntityFrameworkCore;
using Brainworks.Gas.Agency.System.Data;

namespace BrainWorks.GAS.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<City> Cities { get; set; } 
        public DbSet<ConnectionType> ConnectionTypes { get; set; }
        public DbSet<ConnectionDetails> ConnectionDetails { get; set; }
        public DbSet<Documents> Documents { get; set; }
        public DbSet<BookingDetails> BookingDetails { get; set; }
        public DbSet<SiteContent> SiteContents { get; set; }


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

            //State
            modelBuilder.Entity<State>().Property(b => b.Name).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<State>().Property(b => b.ShortCode).HasColumnType("varchar(10)");

            //District
            modelBuilder.Entity<District>().Property(b => b.Name).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<District>().Property(b => b.ShortCode).HasColumnType("varchar(10)").IsRequired();

            //City
            modelBuilder.Entity<City>().Property(b => b.Name).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<City>().Property(b => b.ShortCode).HasColumnType("varchar(10)").IsRequired();

            //ConnectionType
            modelBuilder.Entity<ConnectionType>().Property(b => b.Name).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<ConnectionType>().Property(b => b.Description).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<ConnectionType>().Property(b => b.RefillCharge).HasColumnType("money").IsRequired();
            modelBuilder.Entity<ConnectionType>().Property(b => b.NewConnectionCharge).HasColumnType("money").IsRequired();

            //ConnectionDetails
            modelBuilder.Entity<ConnectionDetails>().Property(b => b.ConsumerNumber).HasColumnType("int").IsRequired();
            modelBuilder.Entity<ConnectionDetails>().Property(b => b.ConsumerName).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<ConnectionDetails>().Property(b => b.DeliveryAddress).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<ConnectionDetails>().Property(b => b.ConnectionRequestDate).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<ConnectionDetails>().Property(b => b.ConnectionApprovedDate).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<ConnectionDetails>().Property(b => b.DepositAmount).HasColumnType("money").IsRequired();
            modelBuilder.Entity<ConnectionDetails>().Property(b => b.Regulator).HasColumnType("int").IsRequired();
            modelBuilder.Entity<ConnectionDetails>().Property(b => b.Status).HasColumnType("varchar(50)").IsRequired();

            //Documents
            modelBuilder.Entity<Documents>().Property(b => b.Document).HasColumnType("binary").IsRequired();
            modelBuilder.Entity<Documents>().Property(b => b.Type).HasColumnType("varchar").IsRequired();

            //BookingDetails
            modelBuilder.Entity<BookingDetails>().Property(b => b.BookedDate).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<BookingDetails>().Property(b => b.DeliveredDate).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<BookingDetails>().Property(b => b.Status).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<BookingDetails>().Property(b => b.Amount).HasColumnType("money").IsRequired();

            //SiteContent
            modelBuilder.Entity<SiteContent>().Property(b => b.Reference).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<SiteContent>().Property(b => b.Key).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<SiteContent>().Property(b => b.Value).HasColumnType("varchar(500)").IsRequired();
        }
    }
}
