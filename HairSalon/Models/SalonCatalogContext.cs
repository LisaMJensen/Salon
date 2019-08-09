using Microsoft.EntityFrameworkCore;

namespace SalonCatalog.Models
{
  public class SalonCatalogContext : DbContext
  {
    public DbSet<Client> Clients { get; set; }
    public virtual DbSet<Stylist> Stylists { get; set; }
    
    public SalonCatalogContext(DbContextOptions options) : base(options) { }
  }
}