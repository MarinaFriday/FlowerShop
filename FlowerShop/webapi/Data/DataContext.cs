using Microsoft.EntityFrameworkCore;
using webapi.Models.Expanses;
using webapi.Models.Flowers;
using webapi.Models.Sales;

namespace webapi.Data
{
    //наследуемся от DbContext
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
            Database.EnsureCreated();
            
        }

        public DbSet<Models.Expanses.Category> ExpansesCategories { get; set; }
        public DbSet<Expanse> Expanses { get; set; }
        public DbSet<Models.Flowers.Category> FlowersCategories {get; set;}
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Models.Sales.Category> SalesCategories { get; set; }  
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expanse>()
                .HasOne(e=>e.Category)
                .WithMany(c=>c.Expanses)
                .HasForeignKey(e=>e.CategoryId);
                
        }
    }
    
}
