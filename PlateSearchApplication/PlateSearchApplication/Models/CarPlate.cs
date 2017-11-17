﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlateSearchApplication.Models
{
    public class CarPlate
    {
        [Key]
        public int PlateId { get; set; }
        [MaxLength(7, ErrorMessage = "The input plate is too long")]
        public string Plate { get; set; }
        public string Car_brand { get; set; }
        public string Car_model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
    }
}
