using CompanyWebsite.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyWebsite.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}