using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Security;
using NewProjectWeb.Models.Classes;
using NewProjectWeb.Models.Context;

namespace NewProjectWeb.Controllers
{
    public class LoginController : Controller
    {
        DataBaseContext context = new DataBaseContext();
        // GET: Login
        
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var user = context.Admins.FirstOrDefault(x => x.UserName == ad.UserName && x.Password == ad.Password);

            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                Session["UserName"] = user.UserName.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.hatagonder = "Kullanıcı Adı ya da Şifre hatalı tekrar deneyiniz.";
                return View();
            }
        }
        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            HttpContext.Session.Clear();
            HttpContext.Session.Abandon();
            HttpContext.Request.Cookies.Clear();
            HttpContext.Response.Cookies.Clear();
            return RedirectToAction("Login", "Login");
        }
    }
}