namespace SalonCatalog.Models
{
    public class Stylist
    {
        public int StylistId { get; set; }
        public string Description { get; set; }
        public int SalonId { get; set; }
        public virtual Salon Salon { get; set; }
    }
}