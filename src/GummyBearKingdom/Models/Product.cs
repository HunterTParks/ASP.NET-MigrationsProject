using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GummyBearKingdom.Models
{
    public class Product
    {
        [Key]
        public int ProductId;
        public string Name;
        public int CountryId;
        public virtual Country Country { get; set; }
    }
}
