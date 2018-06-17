using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conselho.Models
{
    public class DistribuicaoDeAulaViewModel
    {
        public int itemSelecionado { get; set; }
        public List<Disciplina> ListaDisciplinas { get; set; }
        public List<Professor> ListaProfessores { get; set; }

     }
}