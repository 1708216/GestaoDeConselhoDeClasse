using Conselho.Models;
using Conselho.Models.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conselho.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {

            MeuContexto contexto = new MeuContexto();
            List<FichaDeMatricula> lista = contexto.FichasDeMatricula.ToList(); 


            return View(lista);
        }
    }
}