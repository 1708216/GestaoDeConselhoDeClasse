using Conselho.Models;
using Conselho.Models.Dal;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Conselho.Controllers
{
    public class FichaDeMatriculaController : Controller
    {
        // Tela inicial onde são listados os alunos 
        public ActionResult Index()
        {
            MeuContexto contexto = new MeuContexto();
            List<Aluno> alunos = contexto.Alunos.ToList();

            return View(alunos);
        }

        // Tela inicial onde são listadas as Turmas para depois inserir 
        //os alunos
        public ActionResult Index2()
        {
            MeuContexto contexto = new MeuContexto();
            List<Turma> turmas = contexto.Turmas.ToList();

            return View(turmas);
        }


        // Salva no banco as fichas que são geradas.
        [HttpPost]
        public ActionResult Create(FichaDeMatricula ficha)
        {
            try
            {
                MeuContexto contexto = new MeuContexto();
                contexto.FichasDeMatricula.Add(ficha);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // método get de mátricula, relaciona o aluno e retorna o conjunto de turmas
        // para ser associada ao aluno através de uma ViewModel
        public ActionResult Matricular(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MeuContexto contexto = new MeuContexto();
            Aluno aluno = contexto.Alunos.Find(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            var model = new MatriculaViewModel();
            model.alunosParaMatricular = aluno;
            model.turmasParaMatricula = contexto.Turmas.ToList();

            return View(model);
        }


        [HttpPost, ActionName("Matricular")]
        [ValidateAntiForgeryToken]
        public ActionResult Matricular(int id)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // método get de mátricula, relaciona a turma e retorna o conjunto de alunos
        // para ser associados à turma através de uma ViewModel
        public ActionResult MatricularViaSala(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MeuContexto contexto = new MeuContexto();

           Turma turma = contexto.Turmas.Find(id);
            if (turma == null)
            {
                return HttpNotFound();
            }
            var model = new MatriculaViaTurmaViewModel();
            model.alunosParaMatricular = contexto.Alunos.ToList();
            model.turma = turma;
            return View(model);
        }

        //Efetua as mátriculas que são enviadas das duas ViewModel
        public ActionResult EfetuarMatricula(int? idTurma, int? idAluno)
        {

            MeuContexto contexto = new MeuContexto();
            FichaDeMatricula fichaMatricula = new FichaDeMatricula();

            fichaMatricula._Aluno = contexto.Alunos.Find(idAluno);
            fichaMatricula._Turma = contexto.Turmas.Find(idTurma);

            contexto.FichasDeMatricula.Add(fichaMatricula);

            Turma turma = contexto.Turmas.Find(idTurma);
            turma._Matriculas.Add(fichaMatricula);

            contexto.SaveChanges();

            return RedirectToAction("Index");

        }


        //// GET: FichaDeMatricula/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: FichaDeMatricula/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: FichaDeMatricula/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: FichaDeMatricula/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

    }
}
