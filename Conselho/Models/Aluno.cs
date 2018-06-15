using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conselho.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string Nome { get; set; }
        public int CGM { get; set; }
        public string Foto { get; set; }

        public bool Situacao { get; set; }




    }
}