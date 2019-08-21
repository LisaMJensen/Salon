using Microsoft.EntityFrameworkCore;

namespace SalonCatalog.Models
{
  public class SalonCatalogContext : DbContext
  {
    public virtual DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }
    
  
    public SalonCatalogContext(DbContextOptions options) : base(options) { }
  }
}