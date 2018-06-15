using Conselho.Models;
using Conselho.Models.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conselho.Controllers
{
    public class DisciplinaController : Controller
    {
        // GET: Disciplina
        public ActionResult Index()
        {
            MeuContexto contexto = new MeuContexto();
            List<Disciplina> lista = contexto.Disciplinas.ToList();


            return View(lista);
        }

        // GET: Disciplina/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Disciplina/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Disciplina/Create
        [HttpPost]
        public ActionResult Create(Disciplina disciplina)
        {
            try
            {
                MeuContexto contexto = new MeuContexto();
                contexto.Disciplinas.Add(disciplina);
                contexto.SaveChanges();
                return RedirectToAction("Index", "Cadastro");
            }
            catch
            {
                return View();
            }
        }

        // GET: Disciplina/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Disciplina/Edit/5
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

        // GET: Disciplina/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Disciplina/Delete/5
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
