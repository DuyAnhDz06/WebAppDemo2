using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppDemo2.Models;

namespace WebAppDemo2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebAppDemo2.Models.Book> Book { get; set; }
        public DbSet<WebAppDemo2.Models.Category> Category { get; set; }
        public DbSet<WebAppDemo2.Models.User> User { get; set; }
        public DbSet<WebAppDemo2.Models.Order> Order { get; set; }
    }
}