using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewProjectWeb.Models.Classes
{
    public class Productbrand
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Görseli giriniz.")]
        public string ProductbrandImage { get; set; }
    }
}