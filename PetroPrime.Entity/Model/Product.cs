using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.Entity.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDetails { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; }

        public ICollection<Supplier> Supplier { get; set; }
    }
}
