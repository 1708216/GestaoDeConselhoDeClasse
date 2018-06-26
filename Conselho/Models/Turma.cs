using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conselho.Models
{
    public class Turma
    {
        public int TurmaID { get; set; }
        public string Serie { get; set; }
        public string Nome { get; set; }
        public string Turno { get; set; }

        public int FichaDeMatriculaID { get; set; }
        public virtual List<FichaDeMatricula> _Matriculas {get;set;}

        public int FichaDeDistribuicaoID { get; set; }
        public virtual List<FichaDeDistribuicao> _DistribuicaoAula { get; set; }  
        
    }
}