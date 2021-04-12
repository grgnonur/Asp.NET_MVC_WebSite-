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
        [Required(ErrorMessage = "Ürün İsmini Giriniz.")]
        [MinLength(10, ErrorMessage = "Ürün ismi 10 karakterden az girilemez.")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Ürün Açıklaması Giriniz.")]
        [MinLength(10, ErrorMessage = "Ürün Açıklaması 10 karakterden az girilemez.")]
        public string ProductDescription { get; set; }
        [Required(ErrorMessage = "Ürün Görselini Giriniz.")]
        public string ProductImage { get; set; }
    }
}