using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.Entity.Model
{

    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public string Status { get; set; }
        public int CartId { get; set; }
    }
}
