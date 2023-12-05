using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Designing.Controllers
{
    public class homepageController : Controller
    {
        // GET: homepage
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult homepage() 
        { 
            return View();
        }
        

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Land()
        {
            return View();
        }

        public ActionResult Category()
        {
            return View();
        }

        public ActionResult Livestock() 
        {
            return View();
        }
    }
}