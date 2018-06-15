using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conselho.Models
{
    public class Professor
    {
        public int ProfessorID { get; set; }
        public string Nome { get; set; }
        public bool Situacao { get; set; }
    }
}