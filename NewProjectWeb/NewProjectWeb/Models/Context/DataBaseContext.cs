using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NewProjectWeb.Models.Classes;

namespace NewProjectWeb.Models.Context
{
    public class DataBaseContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Productbrand> Productbrands { get; set; }
    }
}