using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conselho.Models
{
    public class Login
    {
        public int LoginID { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public Boolean Admin { get; set; }
        public Boolean Status { get; set; }

        public int ProfessorID { get; set; }
        public Professor _Professor { get; set; } 
      

    }
}