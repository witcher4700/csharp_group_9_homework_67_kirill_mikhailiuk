﻿using Microsoft.EntityFrameworkCore;
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

    }
}
