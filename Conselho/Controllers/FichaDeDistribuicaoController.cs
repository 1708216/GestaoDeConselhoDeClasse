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
            DistribuicaoDeAulaViewModel model = new DistribuicaoDeAulaViewModel();

            model.ListaDisciplinas = contexto.Disciplinas.ToList();
            model.ListaProfessores = contexto.Professores.ToList();
            model.ListaTurmas = contexto.Turmas.ToList();

            return View(model);
        }
    }
}