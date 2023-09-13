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

        //Removed Customer Id from here.
        public int TotalAmount { get; set; }
        
        //Removed DateAdded from table.
        //Removed Quantity from table.
    }
}
