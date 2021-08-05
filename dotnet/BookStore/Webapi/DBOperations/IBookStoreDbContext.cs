using Microsoft.EntityFrameworkCore;
using Webapi.Entities;

namespace Webapi.DBOperations
{
    public interface IBookStoreDbContext
    {
        DbSet<Book> Books { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<Author> Authors { get; set; }
        DbSet<User> Users { get; set; }
        int SaveChanges();


    }
}