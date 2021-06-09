using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketBooking.Context;
using TicketBooking.Models;

namespace TicketBooking.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            MyContext myContext = new MyContext();
            var user = myContext.Admins.FirstOrDefault((a => a.UserName == admin.UserName && a.Password == admin.Password));
            if (user != null)
            {
                return View("Index");
            }
            else
            {
                return View("Login");
            }
          
        }
    }
}