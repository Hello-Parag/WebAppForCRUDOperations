using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_DOTNET6.Models;

namespace CRUD_DOTNET6.Data
{
    public class CRUD_DOTNET6Context : DbContext
    {
        public CRUD_DOTNET6Context (DbContextOptions<CRUD_DOTNET6Context> options)
            : base(options)
        {
        }

        //public DbSet<CRUD_DOTNET6.Models.Person> Person { get; set; }
        //public DbSet<CRUD_DOTNET6.Models.PersonVisit> PersonVisit { get; set; }
        public DbSet<CRUD_DOTNET6.Models.ExaminePerson> ExaminePerson { get; set; }
        public object ExaminePersons { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExaminePerson>().HasData(
                new ExaminePerson
                {
                    Id = 1,
                    Name = "Rahul Sharma",
                    Oraganization = "ABC University",
                    ContactDetails = "32568.1254.3325",
                    Feedback = "UX Part of app is good."

                },
                new ExaminePerson
                {
                    Id = 2,
                    Name = "Vivek Lambha",
                    Oraganization = "XYZ Solutions",
                    ContactDetails = "235657.2365.3258",
                    Feedback = "Works well with CRUD Operations."

                },
                 new ExaminePerson
                 {
                     Id = 3,
                     Name = "Ayush Srivastava",
                     Oraganization = "PQR Pvt. L.",
                     ContactDetails = "32546.4569.2245",
                     Feedback = "This Web App Works Good."

                 },
                  new ExaminePerson
                  {
                      Id = 4,
                      Name = "Vijay Singh",
                      Oraganization = "JIT",
                      ContactDetails = "65489.2315.4658",
                      Feedback = "Love This App."

                  }


                );
        }
    }
}
