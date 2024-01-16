using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Utility
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<BookType> BookTypes { get; set; }
    }
}
