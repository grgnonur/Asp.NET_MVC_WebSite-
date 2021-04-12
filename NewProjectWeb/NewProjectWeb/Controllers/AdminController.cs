using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using NewProjectWeb.Models.Classes;
using NewProjectWeb.Models.Context;

namespace NewProjectWeb.Controllers
{
    
    public class AdminController : Controller
    {
        // GET: Admin
        DataBaseContext context = new DataBaseContext();

        //Admin Product Process
        [Authorize]
        public ActionResult Index()
        {
            var degerler = context.Products.ToList();
            return View(degerler);
        }
        [Authorize]
        [HttpGet]
        public ActionResult CreateProduct()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult CreateProduct(Product p)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateProduct");
            }
            FileUploadImage(p);

            context.Products.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult DeleteProduct(int id)
        {
            var delete = context.Products.Find(id);
            context.Products.Remove(delete);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult GetProduct(int id)
        {
            var product = context.Products.Find(id);

            return View("GetProduct", product);
        }
        [Authorize]
        public ActionResult UpdateProduct(Product p)
        {
            if (!ModelState.IsValid)
            {
                return View("GetProduct");
            }
            FileUploadImage(p);

            var product = context.Products.Find(p.ID);
            product.ProductName = p.ProductName;
            product.ProductDescription = p.ProductDescription;
            product.ProductImage = p.ProductImage;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //File Upload ile resim Yükleme işlemi Product için
        private void FileUploadImage(Product p)
        {
            if (Request.Files.Count > 0)
            {
                string filename = Path.GetFileName(Request.Files[0].FileName);
                string _filename = DateTime.Now.ToString("yymmssfff") + filename;
                string url = "~/Image/" + _filename;
                Request.Files[0].SaveAs(Server.MapPath(url));
                p.ProductImage = "/Image/" + _filename;
            }
        }




        //Admin About Process
        [Authorize]
        public ActionResult AboutIndex()
        {
            var deger = context.Abouts.ToList();
            return View(deger);
        }
        [Authorize]
        public ActionResult GetAbout(int id)
        {
            var about = context.Abouts.Find(id);
            return View("GetAbout", about);
        }
        [Authorize]
        public ActionResult UpdateAbout(About a)
        {
            if (!ModelState.IsValid)
            {
                return View("GetAbout");
            }
            FileUploadAboutPhoto(a);

            var about = context.Abouts.Find(a.ID);
            about.Description = a.Description;
            about.Photo = a.Photo;
            context.SaveChanges();
            return RedirectToAction("AboutIndex");
        }

        //File Upload ile resim Yükleme işlemi About için
        private void FileUploadAboutPhoto(About a)
        {
            if (Request.Files.Count > 0)
            {
                string filename = Path.GetFileName(Request.Files[0].FileName);
                string _filename = DateTime.Now.ToString("yymmssfff") + filename;
                string url = "~/Image/" + _filename;
                Request.Files[0].SaveAs(Server.MapPath(url));
                a.Photo = "/Image/" + _filename;
            }
        }


        //Admin Contact Process
        [Authorize]
        public ActionResult ContactIndex()
        {
            var contact = context.Contacts.ToList();
            return View(contact);
        }
        [Authorize]
        public ActionResult GetContact(int id)
        {
            var contact = context.Contacts.Find(id);
            return View("GetContact", contact);
        }
        [Authorize]
        public ActionResult UpdateContact(Contact c)
        {
            if (!ModelState.IsValid)
            {
                return View("GetContact");
            }
            var contact = context.Contacts.Find(c.ID);
            contact.Address = c.Address;
            contact.PhoneNumber = c.PhoneNumber;
            contact.Mail = c.Mail;
            context.SaveChanges();
            return RedirectToAction("ContactIndex");
        }


        //Admin ProductBrand
        [Authorize]
        public ActionResult ProductbrandIndex()
        {
            var Productbrand = context.Productbrands.ToList();
            return View(Productbrand);
        }
        [Authorize]
        [HttpGet]
        public ActionResult CreateProductbrand()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult CreateProductbrand(Productbrand pb)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateProductbrand");
            }
            FileUploadImage(pb);

            context.Productbrands.Add(pb);
            context.SaveChanges();
            return RedirectToAction("ProductbrandIndex");
        }
        [Authorize]
        public ActionResult DeleteProductbrand(int id)
        {
            var delete = context.Productbrands.Find(id);
            context.Productbrands.Remove(delete);
            context.SaveChanges();
            return RedirectToAction("ProductbrandIndex");
        }
        [Authorize]
        public ActionResult GetProductbrand(int id)
        {
            var productbrand = context.Productbrands.Find(id);
            return View("GetProductbrand",productbrand);
        }
        [Authorize]
        public ActionResult UpdateProductbrand(Productbrand pb)
        {
            if (!ModelState.IsValid)
            {
                return View("GetProductbrand");
            }
            FileUploadImage(pb);

            var productbrand = context.Productbrands.Find(pb.ID);
            productbrand.ProductbrandImage= pb.ProductbrandImage;
            context.SaveChanges();
            return RedirectToAction("ProductbrandIndex");
        }

        //File Upload ile resim Yükleme işlemi Productbrand için
        private void FileUploadImage(Productbrand pb)
        {
            if (Request.Files.Count > 0)
            {
                string filename = Path.GetFileName(Request.Files[0].FileName);
                string _filename = DateTime.Now.ToString("yymmssfff") + filename;
                string url = "~/Image/" + _filename;
                Request.Files[0].SaveAs(Server.MapPath(url));
                pb.ProductbrandImage = "/Image/" + _filename;
            }
        }


    }
}