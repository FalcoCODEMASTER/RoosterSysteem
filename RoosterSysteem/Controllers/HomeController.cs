using RoosterSysteem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoosterSysteem.Controllers
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

        public ActionResult Overzichtgegevens()
        {
            ViewBag.Message = "Overzichten";

            return View();
        }
        public ActionResult Eigengegevens()
        {
            ViewBag.Message = "Eigengegevens";

            return View();
        }
        public ActionResult Vakkeninzien()
        {
            ViewBag.Message = "Vakkeninzien";

            return View();
        }

        // GET: testclass/Details/5
    }
}