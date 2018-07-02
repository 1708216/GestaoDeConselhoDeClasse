﻿using System;
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

        public int FichaDeMatriculaID { get; set; }
        public virtual List<FichaDeMatricula> Matriculas {get;set;}

       public int FichaDeConselhoID { get; set; }
        public virtual List<FichaDeConselho> ListaDeConselhos { get; set; }

    }
}