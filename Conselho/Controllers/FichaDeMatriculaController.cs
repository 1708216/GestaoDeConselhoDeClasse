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
        // GET: FichaDeMatricula
        public ActionResult Index()
        {
            MeuContexto contexto = new MeuContexto();
            List<Aluno> alunos = contexto.Alunos.ToList();

            return View(alunos);
        }


        // POST: FichaDeMatricula/Create
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

        public ActionResult EfetuarMatricula(int? idTurma, int? idAluno)
        {
            MeuContexto contexto = new MeuContexto();

            FichaDeMatricula fichaMatricula = new FichaDeMatricula();
            fichaMatricula._Aluno = contexto.Alunos.Find(idAluno);

            contexto.FichasDeMatricula.Add(fichaMatricula);

            Turma turma = contexto.Turmas.Find(idTurma);
            turma.matriculas.Add(fichaMatricula);

            contexto.SaveChanges();

            return View("Home");

        }



        // GET: FichaDeMatricula/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FichaDeMatricula/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FichaDeMatricula/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FichaDeMatricula/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }






    }
}
