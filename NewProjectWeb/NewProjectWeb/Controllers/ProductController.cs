using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewProjectWeb.Models.Context;

namespace NewProjectWeb.Controllers
{
    public class ProductController : Controller
    {
        DataBaseContext context = new DataBaseContext();
        // GET: Product
        public ActionResult Index()
        {
            var degerler = context.Products.ToList();
            return View(degerler);
        }

        public ActionResult DetailProduct(int id)
        {
            var product = context.Products.Where(x => x.ID == id).ToList();
            return View(product);
        }
    }

    
}