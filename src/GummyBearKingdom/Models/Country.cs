using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GummyBearKingdom.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
