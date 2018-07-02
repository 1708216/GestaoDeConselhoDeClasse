using System.Collections.Generic;
using System.Data.Entity;

namespace Conselho.Models.Dal
{
    public class ConselhoDBInitializer : DropCreateDatabaseIfModelChanges<MeuContexto>
    {
        protected override void Seed(MeuContexto meuContexto)
        {

            List<Aluno> Alunos = new List<Aluno>();
            List<Professor> Professores = new List<Professor>();
            List<Turma> Turmas = new List<Turma>();
            List<Disciplina> Disciplinas = new List<Disciplina>();


            Alunos.Add(new Aluno() { Nome = "GRAZIELA", CGM = 1234, Situacao = true });
            Alunos.Add(new Aluno() { Nome = "MARCOS", CGM = 4321, Situacao = true });

            Professores.Add(new Professor() { Nome = "LUCAS", Situacao = true , Matricula = 123 , Senha="123" });
            Professores.Add(new Professor() { Nome = "MARCELO", Situacao = true ,Matricula = 1234, Senha="1234" });
            Professores.Add(new Professor() { Nome = "MARIA", Situacao = false, Matricula = 12345, Senha = "12345" });

            Disciplinas.Add(new Disciplina() { Nome = "MATEMÁTICA" });
            Disciplinas.Add(new Disciplina() { Nome = "SOCIOLOGIA" });

            Turmas.Add(new Turma() { Serie = "1", Nome = "A", Turno = "MANHÃ" });
            Turmas.Add(new Turma() { Serie = "2", Nome = "B", Turno = "NOITE" });

            meuContexto.Alunos.AddRange(Alunos);
            meuContexto.Professores.AddRange(Professores);
            meuContexto.Disciplinas.AddRange(Disciplinas);
            meuContexto.Turmas.AddRange(Turmas);
            meuContexto.SaveChanges();
        }
    }
}