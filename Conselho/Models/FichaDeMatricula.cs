using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conselho.Models
{
    public class FichaDeMatricula
    {
        public int FichaDeMatriculaID { get; set; }

        public int AlunoID { get; set; }
        public virtual Aluno _Aluno { get; set; }

    }
}