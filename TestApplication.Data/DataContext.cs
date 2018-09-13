using Microsoft.EntityFrameworkCore;
using System;
using TestApplication.Data.Entities;

namespace TestApplication.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Enrolment> Enrolments { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PaymentOption> PaymentOptions { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    HouseNumber = "16",
                    StreetName = "Main Road",
                    City = "Glasgow",
                    Postcode = "G53 7HJ",
                    Id = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now

                }
            );

            modelBuilder.Entity<Enrolment>().HasData(
                new Enrolment
                {
                    Id = 1,
                    Status = Enums.Status.Pending,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    SupplyAddress_Id = 1
                }
            );

            modelBuilder.Entity<PaymentOption>().HasData(
                    new PaymentOption
                    {
                        CardName = "Test User",
                        CardNumber = "1234123412341234",
                        CardType = "VISA",
                        Id = 1,
                        Enrolment_Id = 1,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        ValidUntil = new DateTime(2019, 12, 01)
                    }
                );

        }
    }
}
