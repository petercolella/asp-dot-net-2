using Microsoft.EntityFrameworkCore;

namespace App2.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<App2.Models.Book> Book { get; set; }
    }
}