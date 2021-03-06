﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinExWebApp20256461.Models
{
    public class PersonalShippingAccount: ShippingAccount
    {
        [Required]
        [StringLength(35)]
        public string FirstName { set; get; }
        [Required]
        [StringLength(35)]
        public string LastName { set; get; }
    }
}