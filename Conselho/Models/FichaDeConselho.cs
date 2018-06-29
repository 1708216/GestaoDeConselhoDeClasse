using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conselho.Models
{
    public class FichaDeConselho
    {

        public int FichaDeConselhoID { get; set; }
        public Boolean statusDoConselho { get; set; }
        public int Resposta1 { get; set; }
        public int Resposta2 { get; set; }
        public int Resposta3 { get; set; }
        public int Resposta4 { get; set; }

        public int FichaDeMatriculaID { get; set; }
        public virtual FichaDeMatricula _FichaDeMatricula { get; set; }

        public int FichaDeDistribuicaoID { get; set;}
        public virtual FichaDeDistribicao

        public int ProfessorID { get; set; }
        public virtual Professor _Professor { get; set; }

        public int TurmaID { get; set; }
        public virtual Turma _Turma { get; set; }

        public int AlunoID { get; set; }
        public virtual Aluno _Aluno { get; set; }

        
    }
}