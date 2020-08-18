using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using P_4_5_Diplomado_MVC_Validar_Estudiante.Models;

namespace P_4_5_Diplomado_MVC_Validar_Estudiante.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Estudiante est = new Estudiante();
            return View(est);
        }
        [HttpPost]
        public ActionResult Index(Estudiante est)
        {
            if (ModelState.IsValid)
                return View("Correcto");
            else
                return View(est);
        }
        public ActionResult Correcto()
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
    }
}