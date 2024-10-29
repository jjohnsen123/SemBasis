using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Context
{
    internal class StudentContext : DbContext
    {
        public StudentContext ()
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                Debug.WriteLine("Database created");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-ANE2D06V\\SQLEXPRESS;Initial Catalog=Lek14Students;Integrated Security=SSPI;TrustServerCertificate=true");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[] {
                new Student{StudieId=-1,Name="Olsen", Age=19, StudieStart=DateTime.Now, StudieType=DTO.Model.StudieType.Videreuddannelse},
                new Student{StudieId=-2,Name="Hansen", Age=25, StudieStart=DateTime.Now, StudieType=DTO.Model.StudieType.Bachelor},
                new Student{StudieId=-3, Name ="Jensen", Age =28, StudieStart =DateTime.Now, StudieType =DTO.Model.StudieType.Master},
                new Student{StudieId=-45, Name ="Jeppe Johnsen", Age =26, StudieStart =DateTime.Now, StudieType =DTO.Model.StudieType.Videreuddannelse}

            });
        }
        public DbSet<Student> Students { get; set; }
    }
}
