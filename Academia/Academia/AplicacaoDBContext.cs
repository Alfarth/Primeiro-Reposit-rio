using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Dominio
{
    public class AplicacaoDBContext : DbContext
    {
        public AplicacaoDBContext() : base(nameOrConnectionString: "academiaef6") { }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
