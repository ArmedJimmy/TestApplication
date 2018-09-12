using Microsoft.EntityFrameworkCore;
using System;
using TestApplication.Data.Entities;

namespace TestApplication.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Enrolment> Enrolments { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        //public void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //}
    }
}
