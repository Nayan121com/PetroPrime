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

        //OrderId is removed from here.
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
    }
}
