using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummyBearKingdom.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId;
        public string Name;
        public int CountryId;
        public virtual Country Country { get; set; }
    }
}
