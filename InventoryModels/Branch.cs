﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class Branch
    {
        public int BranchId { get; set; }
        [Required]
        public string BranchName { get; set; }
        public String Description { get; set; }
        [Display(Name = "Currency")]
        public int CurrencyId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [Display(Name ="Contact Person")]
        public string ContactPerson { get; set; }
    }
}
