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

        public virtual DbSet<AboutModel> Abouts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AboutModel>().HasData(
                new AboutModel {
                    Id=1,
                    Name="Okan İZİ",
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
