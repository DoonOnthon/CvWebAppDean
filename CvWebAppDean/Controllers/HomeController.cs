using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvWebAppDean.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            DateTime birthDate = Convert.ToDateTime("30/10/2000");
            DateTime todayDate = DateTime.Today;
            int age = todayDate.Year - birthDate.Year;
            if (birthDate > todayDate.AddYears(-age))
            {
                age--;
            }
            ViewBag.AgeAboutMe = age;
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult HomeProjects()
        {
            return View();
        }

        public ActionResult EducationalProjects()
        {
            return View();
        }
    }
}