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
            //DistribuicaoDeAulaViewModel model = new DistribuicaoDeAulaViewModel();

            //model.ListaDisciplinas = contexto.Disciplinas.ToList();
            ViewBag.ProfessorID = new SelectList(contexto.Professores, "ProfessorID", "Nome");
            Turma t = contexto.Turmas.Find(id);

            List<Disciplina> disciplinas = contexto.Disciplinas.ToList();

            List<FichaDeDistribuicao> fichas = new List<FichaDeDistribuicao>();

            foreach (Disciplina d in disciplinas)
            {
                fichas.Add(new FichaDeDistribuicao() { TurmaID = t.TurmaID, DisciplinaID = d.DisciplinaID });
            }

            return View(fichas);

        }

        [HttpPost]
        //public ActionResult DistribuiAula( int idDisciplina,int idTurma, int idProf)
        public ActionResult AtribuicaoDeAula(IEnumerable<FichaDeDistribuicao> fichas)
        {
            MeuContexto contexto = new MeuContexto();

            //List<Disciplina> disciplinas = contexto.Disciplinas.ToList();

            //List<FichaDeDistribuicao> fichas = new List<FichaDeDistribuicao>();

            //foreach (Disciplina d in disciplinas)
            //{
            //    fichas.Add(new FichaDeDistribuicao() { TurmaID = 1, DisciplinaID = d.DisciplinaID });
            //}

            if(ModelState.IsValid)
            {

            }


            ViewBag.ProfessorID = new SelectList(contexto.Professores, "ProfessorID", "Nome");


            return View(fichas);
        }

        public ActionResult AdicionarProfessor(int Id)
        {


            MeuContexto contexto = new MeuContexto();


            List<Professor> lista = contexto.Professores.ToList();



            return View(lista);
        }

    }
}