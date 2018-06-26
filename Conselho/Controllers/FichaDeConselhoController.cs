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
            List<Professor> professores = contexto.Professores.ToList();


            return View(professores);
        }

        public ActionResult EscolhaProfessor()
        {

            MeuContexto contexto = new MeuContexto();
            List<Professor> listaDeprofessor = contexto.Professores.ToList();
            ViewBag.professores = listaDeprofessor;


            return View();
        }



        public ActionResult EscolhaTurmas( int idProf)
        {

            MeuContexto contexto = new MeuContexto();
            Professor professor = contexto.Professores.Find(idProf);
            IEnumerable<FichaDeDistribuicao> lista = contexto.FichasDeDistribuicao.Where(f => f._Professor.ProfessorID.Equals(idProf));

             //IEnumerable<FichaDeDistribuicao> resultado = from f in contexto.FichasDeDistribuicao
             //              where f.ProfessorId == idProf
             //              select f;

           

            return View(lista);
        }


    }
}