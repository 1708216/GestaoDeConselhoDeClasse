using Conselho.Models;
using Conselho.Models.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conselho.Controllers
{
    public class FichaDeConselhoController : Controller
    {
        // GET: FichaDeConselho
        public ActionResult Index()
        {

            MeuContexto contexto = new MeuContexto();

             ViewBag.professores = contexto.Professores.ToList();

            return View();
        }

        public ActionResult SelecionarTurmas( int idProf)
        {

            MeuContexto contexto = new MeuContexto();
            Professor professor = contexto.Professores.Find(idProf);
            ViewBag.turmas = professor.ListaDeDistribuicao.ToList();

            return View();
        }


    }
}