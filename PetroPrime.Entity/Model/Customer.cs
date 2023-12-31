﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.Entity.Model
{
    //Master Table
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string CustomerPassword { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string CustomerPhone { get; set; }
    }
}
