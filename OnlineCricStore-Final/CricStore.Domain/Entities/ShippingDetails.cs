﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CricStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Please Enter City Name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter State Name")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Please Enter Country Name")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }

    }
}
