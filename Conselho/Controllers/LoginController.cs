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
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ValidaLogin(int txtLogin, string txtSenha)
        {

            MeuContexto contexto = new MeuContexto();




            if (txtLogin.Equals("admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                try
                {

                    var professor = (from p in contexto.Professores
                                   where p.Matricula.Equals(txtLogin)
                                     select new Professor
                                   {
                                       Matricula = p.Matricula,
                                       ProfessorID = p.ProfessorID,
                                       Senha = p.Senha                                                                                                                                      
       
                                   }).First();

                    if (professor != null)
                    {
                        if (professor.Senha.Equals("txtSenha"))
                        {
                            return RedirectToAction("Index", "Home");

                        }
                        else
                        {
                            //senha inválida
                            return View("Index");
                        }
                    }
                    else
                    {
                        //usuario inválido
                        return View("Index");
                    }

                }
                catch (Exception)
                {
                    return View("Index");
                }

            }
        }


    }
}
