using Microsoft.EntityFrameworkCore;

namespace Barang.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Section> Section { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Item> Item { get; set; }


    }
}
