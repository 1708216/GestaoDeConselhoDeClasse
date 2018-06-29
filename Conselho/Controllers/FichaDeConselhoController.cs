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
            var resultado = from f in contexto.FichasDeDistribuicao
                            where f._Professor.ProfessorID.Equals(idProf)
                            select f;

            return View(resultado.ToList());
        }

        public ActionResult IniciaConselho(int idTurma, int idProf)
        {

            MeuContexto contexto = new MeuContexto();
            var resultado = contexto.Turmas.Find(idTurma);
      
            return View(resultado);
        }

        public ActionResult AvaliarAlunos()
        {

            return View(); 
        }




    }
}