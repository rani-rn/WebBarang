using Microsoft.EntityFrameworkCore;

namespace Barang.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Section> Sections {  get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }

        

    }
}
