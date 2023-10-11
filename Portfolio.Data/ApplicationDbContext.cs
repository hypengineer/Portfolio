using Microsoft.EntityFrameworkCore;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        }

        public virtual DbSet<About> Abouts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<About>().HasData(
                new About {
                    Id=1,
                    Title="Title",
                    Description="Description area",
                    Birthday= DateTime.Parse("1994-10-01"),
                    Age = 29,
                    Degree = "Degree Area",
                    Phone = "Phone Number",
                    Email = "Email Area",
                    City = "City Area",
                    ImageUrl= ""
                } );
        }



    }
}
