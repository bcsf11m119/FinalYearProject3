using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationFyp.Models;


namespace WebApplicationFyp.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        //public ActionResult Index()
        //{
        //    return View();
        //}

        IData data;
        Parent p;
        public AccountController(IData d)
        //: this(new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
        {
            data = d;
        }

        //public AccountController(UserManager<ApplicationUser> userManager)
        //{
        //    //UserManager = userManager;
        //}

        public ActionResult Login()
        {
            return View();

        }

        //[HttpPost]
        public ActionResult Verify()
        {
            String name = Request["Username"];
            String pass = Request["password"];
            bool st = data.verify(name, pass);
            if (st)
            {
                p = data.get(name);
                this.Session["Parent"] = p;
                ViewBag.x = p;
                return View(data.getChild(p));
                //ViewBag.x = p.Children.ToList();
                //return View(p.Children.ToList<Child>());

            }
            else
                return View("onError");
        }
        public ActionResult Result()
        {

            string name = Request["opt"];
            p = (Parent)this.Session["Parent"];
            Child c = p.Children.First(x => x.Name.Equals(name));

            return View(c);
        }
	}
}