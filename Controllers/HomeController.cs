using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationFyp.Models;
namespace WebApplicationFyp.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    ViewBag.Title = "Home Page";

        //    return View();
        //}

        Parent p;
        public ActionResult Index()
        {
            p = (Parent)this.Session["Parent"];
            ViewBag.x = p;
            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            p = (Parent)this.Session["Parent"];
            ViewBag.x = p;
            return View();
        }

        public ActionResult Contact()
        {
            p = (Parent)this.Session["Parent"];
            ViewBag.x = p;
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Support()
        {
            p = (Parent)this.Session["Parent"];
            ViewBag.x = p;
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
