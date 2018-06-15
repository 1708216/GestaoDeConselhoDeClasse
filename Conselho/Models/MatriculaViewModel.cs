using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conselho.Models
{
    public class MatriculaViewModel
    {
        public IEnumerable<Turma> turmasParaMatricula { get; set;}
        public Aluno alunosParaMatricular { get; set; }

    }
}