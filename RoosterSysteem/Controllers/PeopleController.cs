using RoosterSysteem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoosterSysteem.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<UserModel> people = new List<UserModel>();

            people.Add(new UserModel { username = "Falco", password = "Wenteler",name = "Falco", email = "Falcowenteler@hotmail.com" });
            people.Add(new UserModel { username = "Stan", password = "Verbeek", name = "Stan", email = "Stanverbeek@hotmail.com" });
            people.Add(new UserModel { username = "Rianne", password = "Docent", name = "Rianna", email = "-" });

            return View(people);
        }
    }
}