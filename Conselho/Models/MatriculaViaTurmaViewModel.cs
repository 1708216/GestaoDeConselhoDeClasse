using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conselho.Models
{
    public class MatriculaViaTurmaViewModel
    {

        public Turma turma { get; set; }
        public List<Aluno> alunosParaMatricular { get; set; }

    }
}