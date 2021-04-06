using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewProjectWeb.Models.Classes
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Hakkımızda Açıklaması Boş Geçilemez.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Hakkımızda Görseli Boş Geçilemez.")]
        public string Photo { get; set; }
    }
}