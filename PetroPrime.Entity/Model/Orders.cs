using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.Entity.Model
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
        public string DeliveryStatus { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<Courrier> Courrier { get; set; }
    }
}
