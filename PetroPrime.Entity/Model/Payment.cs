﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.Entity.Model
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int CartId { get; set; }
        public string Status { get; set; }
        public int Amount { get; set; }
    }
}