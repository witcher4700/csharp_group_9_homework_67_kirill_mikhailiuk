using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework67.Models
{
    public class CountryContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public CountryContext(DbContextOptions<CountryContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
            new { Id = 1, Name = "USA"},
            new { Id = 2, Name = "England"},
            new { Id = 3, Name = "Albania"},
            new { Id = 4, Name = "Russia"},
            new { Id = 5, Name = "KG"},
            new { Id = 6, Name = "KZ"},
            new { Id = 7, Name = "Canada"},    
            new { Id = 8, Name = "Greece"},
            new { Id = 9, Name = "Italy"},
            new { Id = 10, Name = "Spain"}
            );
        }
    }
}
