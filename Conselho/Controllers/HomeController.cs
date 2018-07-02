using Conselho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conselho.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            LoginController controle = new LoginController();
            Professor professor = controle.professorLogado;

            LoginPatialViewModel model = new LoginPatialViewModel();

            model.professor = professor;

            return View(model);
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

        public ActionResult IndexProfessor()
        {

            return View();

        }

        public ActionResult _LoginPartialProfessor()
        {

            LoginController controle = new LoginController();
            Professor professor = controle.professorLogado;

            LoginPatialViewModel model = new LoginPatialViewModel();

            model.professor = professor;

            return View(model);
        }

    }
}