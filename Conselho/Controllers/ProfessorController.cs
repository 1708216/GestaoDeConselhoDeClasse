using Conselho.Models;
using Conselho.Models.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conselho.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: Professor
        public ActionResult Index()
        {
            MeuContexto contexto = new MeuContexto();
            List<Professor> professores = contexto.Professores.ToList();

            return View(professores);
        }

        // GET: Professor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Professor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Professor/Create
        [HttpPost]
        public ActionResult Create(Professor professor)
        {
            try
            {
                MeuContexto contexto = new MeuContexto();
                contexto.Professores.Add(professor);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index","Cadastro");
            }
        }

        // GET: Professor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Professor/Edit/5
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

        // GET: Professor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Professor/Delete/5
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
