using System;
using Microsoft.EntityFrameworkCore;

namespace ManuelStripePayment.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
