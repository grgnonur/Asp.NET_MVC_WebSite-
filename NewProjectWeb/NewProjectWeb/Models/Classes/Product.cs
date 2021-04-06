using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewProjectWeb.Models.Classes
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Ürün İsmini Giriniz.")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Ürün Açıklaması Giriniz.")]
        public string ProductDescription { get; set; }
        [Required(ErrorMessage = "Ürün Görselini Giriniz.")]
        public string ProductImage { get; set; }
    }
}