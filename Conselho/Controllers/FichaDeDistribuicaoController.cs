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


        public ActionResult EfetivaDistribuicao(int idTurma, int idProf)
        {
            MeuContexto contexto = new MeuContexto();

            AtribuicaoDeAulaViewModel model = new AtribuicaoDeAulaViewModel();

            model.ListaDisciplinas = contexto.Disciplinas.ToList();
            model._Professor = contexto.Professores.Find(idProf);
            model._Turma = contexto.Turmas.Find(idTurma);

            return View(model);

        }

        public ActionResult Finaliza(int idTurma, int idProf, int idDisc)
        {

            MeuContexto contexto = new MeuContexto();
            FichaDeDistribuicao ficha = new FichaDeDistribuicao();

            ficha._Disciplina = contexto.Disciplinas.Find(idDisc);
            ficha._Professor =  contexto.Professores.Find(idProf);
            ficha._Turma = contexto.Turmas.Find(idTurma);

            contexto.FichasDeDistribuicao.Add(ficha);
           
            Turma turma = contexto.Turmas.Find(idTurma);
            turma._DistribuicaoAula.Add(ficha);

            Professor professor = contexto.Professores.Find(idProf);
            professor.ListaDeDistribuicao.Add(ficha);

            contexto.SaveChanges();

    
            return RedirectToAction("Index","FichaDeDistribuicao",idTurma);

        }

    }
}