using Academia.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Academia.Repository
{
    class RepositorioAluno
    {
        Aluno aluno;

        public int Adicionar(Aluno _aluno)
        {
            aluno = _aluno;
            if (aluno == null) return 0;
            using (var db = new AplicacaoDBContext())
            {
                if (db.Entry<Aluno>(aluno).State == EntityState.Detached)
                    db.Set<Aluno>().Attach(aluno);

                db.Entry<Aluno>(aluno).State = EntityState.Added;

                return db.SaveChanges();

            }
        }

        public int Atualizar(Aluno _aluno)
        {
            aluno = _aluno;
            if (aluno == null) return 0;
            using (var db = new AplicacaoDBContext())
            {
                if (db.Entry<Aluno>(aluno).State == EntityState.Detached)
                    db.Set<Aluno>().Attach(aluno);

                db.Entry<Aluno>(aluno).State = EntityState.Modified;

                return db.SaveChanges();

            }
        }

        public int Excluir(Aluno _aluno)
        {
            aluno = _aluno;
            if (aluno == null) return 0;
            using (var db = new AplicacaoDBContext())
            {
                if (db.Entry<Aluno>(aluno).State == EntityState.Detached)
                    db.Set<Aluno>().Attach(aluno);

                db.Entry<Aluno>(aluno).State = EntityState.Deleted;

                return db.SaveChanges();

            }
        }
    }
}
