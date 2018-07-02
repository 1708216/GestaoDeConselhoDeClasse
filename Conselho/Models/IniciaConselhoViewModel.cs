using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conselho.Models
{
    public class IniciaConselhoViewModel
    {

       public  int TurmaID { get; set; }
       public  virtual Turma _Turma { get; set; }

       public int AlunoId { get; set; }
        public virtual Aluno _Aluno { get; set; }

       public int idProf { get; set; }
       public virtual Professor _Professor { get; set; }

       public  int idDic { get; set; }
       public virtual Disciplina _Disiciplina { get; set; } 
        
    }
}