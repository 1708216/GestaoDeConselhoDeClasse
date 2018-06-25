﻿using Conselho.Models.Dal;
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
            List<Disciplina> disciplinas = contexto.Disciplinas.ToList();
            List<FichaDeDistribuicao> fichas = new List<FichaDeDistribuicao>();

            return View("Index");
        }

        [HttpPost]
        public ActionResult EfetivaDistribuicao(int idTurma, int idProf, int idDisc)
        {
            MeuContexto contexto = new MeuContexto();
            List<Disciplina> disciplinas = contexto.Disciplinas.ToList();
            List<FichaDeDistribuicao> fichas = new List<FichaDeDistribuicao>();

            return View("Index");
        }



    }
}