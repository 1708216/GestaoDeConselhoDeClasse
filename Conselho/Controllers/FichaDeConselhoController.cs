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


        public ActionResult EscolhaTurmas(int idProf)
        {

            MeuContexto contexto = new MeuContexto();
            Professor professor = contexto.Professores.Find(idProf);
            var resultado = from f in contexto.FichasDeDistribuicao
                            where f._Professor.ProfessorID.Equals(idProf)
                            select f;

            return View(resultado.ToList());
        }

        public ActionResult IniciaConselho(int idTurma, int idProf, int idDis)
        {

            MeuContexto contexto = new MeuContexto();
            IniciaConselhoViewModel model = new IniciaConselhoViewModel();

            model._Turma = contexto.Turmas.Find(idTurma);
            model._Professor = contexto.Professores.Find(idProf);
            model._Disiciplina = contexto.Disciplinas.Find(idDis);

            return View(model);
        }


 
        public ActionResult AvaliaAluno(int idAluno, int idTurma, int idProf, int idDis)
        {
            MeuContexto contexto = new MeuContexto();
            IniciaConselhoViewModel model = new IniciaConselhoViewModel();

            model._Turma = contexto.Turmas.Find(idTurma);
            model._Professor = contexto.Professores.Find(idProf);
            model._Disiciplina = contexto.Disciplinas.Find(idDis);
            model._Aluno = contexto.Alunos.Find(idAluno);

            return View(model);
        }

        [HttpPost]
        public ActionResult AvaliaAluno(int idAluno, int idTurma, int idProf, int idDis, int Resp1, int Resp2, int Resp3)
        {
            MeuContexto contexto = new MeuContexto();
            FichaDeConselho ficha = new FichaDeConselho();

            ficha._Aluno = contexto.Alunos.Find(idAluno);
            ficha._Professor = contexto.Professores.Find(idProf);
            ficha._Turma = contexto.Turmas.Find(idTurma);
            ficha._Disciplina = contexto.Disciplinas.Find(idDis);
            ficha.Resposta1 = Resp1;
            ficha.Resposta2 = Resp2;
            ficha.Resposta3 = Resp3;

             Aluno aluno = contexto.Alunos.Find(idAluno);
             aluno.ListaDeConselhos.Add(ficha);

             contexto.SaveChanges();

            return RedirectToAction("IniciaConselho");
        }


        //[HttpPost]
        //public ActionResult IniciaConselho( int idAluno , int idTurma, int idProf, int idDis, int Resp1, int Resp2, int Resp3)
        //{
        //    MeuContexto contexto = new MeuContexto();
        //    IniciaConselhoViewModel model = new IniciaConselhoViewModel();

        //    model._Turma = contexto.Turmas.Find(idTurma);
        //    model._Professor = contexto.Professores.Find(idProf);
        //    model._Disiciplina = contexto.Disciplinas.Find(idDis);

        //    return View();
        //}




    }
}