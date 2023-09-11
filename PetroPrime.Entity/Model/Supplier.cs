using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.Entity.Model
{

    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string SupplierEmail { get; set; }

        [DataType(DataType.Password)]
        public string SupplierPassword { get; set; }
        public int SupplierPhone { get; set; }
        public string Address { get; set; }
        public string LicenseNumber { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
