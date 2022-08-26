using LibraryCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryCatalog.Data
{
    public class BooksApiDbContext : DbContext
    {
        public BooksApiDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BookModel> Books { get; set; }
    }
}
