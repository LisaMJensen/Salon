using System.Collections.Generic;

namespace SalonCatalog.Models
{
    public class Stylist
    {
        public Stylist()
        {
            this.Clients = new HashSet<Client>();
        }

        public int StylistId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}