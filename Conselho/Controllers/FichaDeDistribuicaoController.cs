using Conselho.Models.Dal;
using Conselho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conselho.Controllers
{
    public class FichaDeDistribuicaoController : Controller
    {
        // GET: FichaDeDistribuicao
        public ActionResult Index()
        {

            MeuContexto contexto = new MeuContexto();
            List<Turma> turmas = contexto.Turmas.ToList();
            return View(turmas);

        }


        public ActionResult AtribuicaoDeAula(int id)
        {

            MeuContexto contexto = new MeuContexto();
            DistribuicaoDeAulaViewModel model = new DistribuicaoDeAulaViewModel();

            model.ListaDisciplinas = contexto.Disciplinas.ToList();
            model.ListaProfessores = contexto.Professores.ToList();
            model._turma = contexto.Turmas.Find(id);

            return View(model);



        }

        [HttpPost]
        public ActionResult DistribuiAula( int idDisciplina,int idTurma, int idProf)
            {
                     MeuContexto contexto = new MeuContexto();

                     List<Disciplina> disciplinas = contexto.Disciplinas.ToList();

            List<FichaDeDistribuicao> fichas = new List<FichaDeDistribuicao>();


            return View("Index");
        }

        public ActionResult AdicionarProfessor(int Id)
        {


            MeuContexto contexto = new MeuContexto();


            List<Professor> lista = contexto.Professores.ToList();



            return View(lista);
        }

    }
}