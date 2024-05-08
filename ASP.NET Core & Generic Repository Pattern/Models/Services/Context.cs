using ASP.NET_Core___Generic_Repository_Pattern.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core___Generic_Repository_Pattern.Models.Services
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
