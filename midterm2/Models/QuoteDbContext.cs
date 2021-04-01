using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using midterm2.Models;

namespace midterm2.Models
{
    public class QuoteDbContext : DbContext
    {
        //prepares quote objects for the sqlite database
        public QuoteDbContext(DbContextOptions<QuoteDbContext> options) : base(options)
        {

        }
        //quote objects for the database
        public DbSet<Quote> Quotes { get; set; }
    }
}

