using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lek10bilerMVC.Model;

namespace lek10bilerMVC.DAL
{
    public class BilContext : DbContext
    {
        public BilContext() { }

        public DbSet<Bil> Biler { get; set; }
        public DbSet<Person> Personer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bil>().HasData(new Bil[]
            {
                new Bil
                { BilID = 1, Name = "Ford", Weight = 1400, Year = 2007 }
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-ANE2D06V\\SQLEXPRESS;Initial Catalog=Biler2;Integrated Security=SSPI;TrustServerCertificate=true");
            //bool created = Database.EnsureCreated();
            //if (created)
            //{
            //    Console.WriteLine("Database created.");
            //}
        }
    }
}
