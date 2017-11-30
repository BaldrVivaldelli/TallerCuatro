using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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

        public ActionResult Alumno(Models.AlumnosViewModel vm) {
            ViewBag.Message = "Pagina del alumno";
            vm.Materias = new List<Models.Materia>();
            Session["Alumno"] = vm;
            return View("Alumno",vm);
        }


        public ActionResult Materia(Materia vm)
        {
            ViewBag.Message = "Pagina de la materia";
            AlumnosViewModel aluVM = (AlumnosViewModel)(Session["Alumno"]);
            aluVM.Materias.Add(vm);
            return View("Alumno", aluVM);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}