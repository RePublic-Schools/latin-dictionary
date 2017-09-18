using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using LatinDictionaryNoAuth.Models;

namespace LatinDictionaryNoAuth.Data
{
    //Class Name: LatinDictionaryWebContext
    //Author: Delaine Wendling
    //Purpose of the class: The purpose of this class is to create a context in memory for our Controllers to interact with our Database.
    //Methods in Class: No Methods but DBSets of Customer, LineItem, Order, PaymentType, Product, ProductType
    public class LatinDictionaryWebContext : DbContext
    {
        public LatinDictionaryWebContext(DbContextOptions<LatinDictionaryWebContext> options)
            : base(options)
        { }

        public DbSet<WordType> WordType { get; set; }
        public DbSet<Stage> Stage { get; set; }
        public DbSet<LatinWord> LatinWord { get; set; }
        public DbSet<EnglishWord> EnglishWord { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
// When an English word is being created we are setting a DateCreated property here of current: Year, Month, Day, Hour, Minute, and Second.
            modelBuilder.Entity<EnglishWord>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");

// When a Latin word is being created we are setting a DateCreated property here of current: Year, Month, Day, Hour, Minute, and Second.
            modelBuilder.Entity<LatinWord>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");
        }
    }

}