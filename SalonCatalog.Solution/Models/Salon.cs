using System.Collections.Generic;

namespace SalonCatalog.Models
{
    public class Salon
    {
        public Category()
        {
            this.Stylists = new HashSet<Item>();
        }

        public int SalonId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Item> Stylists { get; set; }
    }
}