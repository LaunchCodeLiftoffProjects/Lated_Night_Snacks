﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.ViewModels
{
    public class AddMenuViewModel
    {
        [Required]
        [Display(Name = "Menu Item")]
        public string MenuItem { get; set; }

        [Required]
        [Display(Name = "Menu Price")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int Qty { get; set; }

        public int Id { get; set; }
    }
}
