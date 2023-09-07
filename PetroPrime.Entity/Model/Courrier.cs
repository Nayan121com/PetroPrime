using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.Entity.Model
{
    public class Courrier
    {
        public int CourrierId { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
    }
}
