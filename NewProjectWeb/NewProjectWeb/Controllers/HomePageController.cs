using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewProjectWeb.Models.Context;

namespace NewProjectWeb.Controllers
{
    public class HomePageController : Controller
    {
        DataBaseContext context = new DataBaseContext();
        // GET: HomePage
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAbout()
        {
            var degerler = context.Abouts.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult PartialProduct()
        {
            var degerler = context.Products.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult PartialContact()
        {
            var degerler = context.Contacts.ToList();
            return PartialView(degerler);
        }
    }
}