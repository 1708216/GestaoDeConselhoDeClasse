using System.Data.Entity;

namespace Conselho.Models.Dal
{
    public class MeuContexto: DbContext
    {
        public MeuContexto() : base("strConn")
        {
            Database.SetInitializer(new ConselhoDBInitializer());
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<FichaDeMatricula> FichasDeMatricula { get; set; }
        public DbSet<FichaDeDistribuicao> FichasDeDistribuicao { get; set; }
    }
}