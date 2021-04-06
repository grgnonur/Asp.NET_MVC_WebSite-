using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewProjectWeb.Models.Classes
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Telefon Numarası Boş Geçilemez.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Adres Boş Geçilemez.")]
        public string Address { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required(ErrorMessage = "Mail Boş Geçilemez.")]
        public string Mail { get; set; }
    }
}