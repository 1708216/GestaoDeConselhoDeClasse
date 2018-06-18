using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conselho.Models
{
    public class FichaDeDistribuicao
    {
        public int FichaDeDistribuicaoID { get; set; }

        public virtual Professor _Professor { get; set; } 
        public virtual Disciplina _Disciplina { get; set; }
        public virtual Turma  _Turma { get; set; }
    }
}