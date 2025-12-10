using DistributedCaching.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace DistributedCaching.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }
    }
}
