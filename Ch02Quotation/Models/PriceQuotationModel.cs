using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ch02Quotation.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Please enter a Subtotal")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a Subtotal greater than 0")]
        public decimal? SubTotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount amount")]
        [Range(0, 100, ErrorMessage = "Discount amount must be between 0 and 100 percent.")]
        public decimal? DiscountPercent { get; set; }

        public decimal? DiscountAmount { get; set; }   

        public decimal? Total { get; set; }
        public decimal? CalculateDiscountAmount()
        {
            decimal? discountAmount = (DiscountPercent/100) * SubTotal;
            return discountAmount;

        }
        public decimal? CalculateTotal()
        {
            decimal? total = SubTotal - ((DiscountPercent/100) * SubTotal);
            return total;
        }
    }
    
}
