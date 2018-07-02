using Conselho.Models;
using Conselho.Models.Dal;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Conselho.Controllers
{
    public class AlunoController : Controller
    {
        public ActionResult Index()
        {
            MeuContexto contexto = new MeuContexto();
            List<Aluno> alunos = contexto.Alunos.ToList();

            return View(alunos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Aluno aluno)
        {
            try
            {
                MeuContexto contexto = new MeuContexto();
                contexto.Alunos.Add(aluno);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index", "Cadastro");
            }
        }

   
        // GET: Aluno/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

     
        // POST: Aluno/Edit/5
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

     
        //GET
        public ActionResult Delete(int? id)
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

            return View(aluno);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MeuContexto contexto = new MeuContexto();
            Aluno aluno = contexto.Alunos.Find(id);

            contexto.Alunos.Remove(aluno);
            contexto.SaveChanges();

            return RedirectToAction("Index");
        }


        // GET: Aluno/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


    }




}






