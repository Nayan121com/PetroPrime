using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.Entity.Model
{
    public class ProductSupplier
    {
        [Key]
        public int ProdSuppId { get; set; }
        public int SupplierId { get; set;}
        public int ProductId { get; set; }
    }
}
