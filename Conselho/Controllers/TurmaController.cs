using Conselho.Models;
using Conselho.Models.Dal;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Conselho.Controllers
{
    public class TurmaController : Controller
    {
        // GET: Turma
        public ActionResult Index()
        {
            MeuContexto contexto = new MeuContexto();
            List<Turma> turmas = contexto.Turmas.ToList();
            return View(turmas);
        }

        // GET: Turma/Details/5
        public ActionResult Details(int id)
        {

            MeuContexto contexto = new MeuContexto();
            Turma turma = contexto.Turmas.Find(id);

            return View(turma);
        }

        // GET: Turma/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Turma/Create
        [HttpPost]
        public ActionResult Create(Turma turma)
        {
            try
            {
                MeuContexto contexto = new MeuContexto();
                contexto.Turmas.Add(turma);
                contexto.SaveChanges();

                return RedirectToAction("Index", "Cadastro");
            }
            catch
            {
                return View();
            }
        }

        // GET: Turma/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Turma/Edit/5
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


        public ActionResult Delete(int? id)
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

            return View(turma);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            MeuContexto contexto = new MeuContexto();
            Turma turma = contexto.Turmas.Find(id);

            contexto.Turmas.Remove(turma);
            contexto.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}



