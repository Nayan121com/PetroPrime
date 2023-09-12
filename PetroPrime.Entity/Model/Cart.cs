using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.Entity.Model
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int TotalAmount { get; set; }
        public DateTime DateAdded { get; set; }
        public int Quantity { get; set; }
        public ICollection<Product> Product { get; set; }
        public Payment Payment { get; set; }
    }
}
