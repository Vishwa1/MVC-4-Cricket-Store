using OnlineCricStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCricStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View();
        }

        //[Authorize (Roles = "admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactModel contact)
        {
            if (ModelState.IsValid)
            {
                ViewBag.SuccessMessage = "Contact Inserted Successfully";
          }
            return View(contact);
        }

        public ActionResult Career()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
      }
}
