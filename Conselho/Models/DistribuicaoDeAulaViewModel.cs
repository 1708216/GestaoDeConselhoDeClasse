using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conselho.Models
{
    public class DistribuicaoDeAulaViewModel
    {
        public int itemSelecionado { get; set; }

        public virtual List<Turma> ListaTurmas { get; set; }
        public virtual List<Disciplina> ListaDisciplinas { get; set; }
        public virtual List<Professor> ListaProfessores { get; set; }

     }
}