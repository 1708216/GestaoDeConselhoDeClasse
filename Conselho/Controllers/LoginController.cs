using Conselho.Models;
using Conselho.Models.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conselho.Controllers
{
    public class LoginController : Controller
    {

        public  Professor professorLogado { get; set; }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ValidaLogin(int txtLogin, string txtSenha)
        {

                MeuContexto contexto = new MeuContexto();

            var resultado = from p in contexto.Professores
                            where p.Matricula.Equals(txtLogin)
                            select p;

            if (resultado != null)
            {
                Professor professor = resultado.SingleOrDefault();

                if (professor.Situacao == true)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    if (professor.Senha.Equals(txtSenha))
                    {
                        professorLogado = professor;
                        return RedirectToAction("IndexProfessor" ,"Home" );
                    }
                    else
                    {
                        return View("Index");
                    }

                }
            }
            else
            {

                return View("Index");
            }
        }


        public ActionResult _LoginPartialProfessor()
        {  
           Professor professor = professorLogado;
           LoginPatialViewModel model = new LoginPatialViewModel();
           model.professor = professor;
           return View(model);

        }



    }
}


