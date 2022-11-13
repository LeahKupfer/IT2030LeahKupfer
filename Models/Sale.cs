﻿using System.ComponentModel.DataAnnotations;

namespace LeahSporting.Models
{
    public class Sale
    {
        [Required(ErrorMessage ="Please enter a value for sale amount")]
        [Range(0, double.MaxValue, ErrorMessage = "Sale price must be greater than 0")]
        public decimal? SaleAmount { get; set; }

        [Required(ErrorMessage = "Please enter a value for tax rate")]
        [Range(0, 10, ErrorMessage = "Tax Rate must be between 0 and 10")]
        public decimal? TaxRate { get; set; }

        public decimal? TaxAmount ()
        { 
            return (SaleAmount * TaxRate / 100);
        }
        public decimal? TotalSalePrice()
        {
            return (SaleAmount + TaxAmount());
        }

    }
}