using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.Entity.Model
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int TotalAmount { get; set; }
        public int NumberOfItem { get; set; }
        public int CustomerId { get; set; }
    }
}
