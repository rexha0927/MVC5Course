using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.ViewModels
{
    public class ProductsListVM
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        [Range(0, 999, ErrorMessage = "商品金額介於0~999之間")]
        public Nullable<decimal> Price { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:#}")]
        public Nullable<decimal> Stock { get; set; }
    }
}