using Academia.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Academia.Repository
{
    class RepositorioProfessor
    {
        Professor professor;

        public int Adicionar(Professor _professor)
        {
            professor = _professor;
            if (professor == null) return 0;
            using (var db = new AplicacaoDBContext())
            {
                if (db.Entry<Professor>(professor).State == EntityState.Detached)
                    db.Set<Professor>().Attach(professor);

                db.Entry<Professor>(professor).State = EntityState.Added;

                return db.SaveChanges();

            }
        }

        public int Atualizar(Professor _professor)
        {
            professor = _professor;
            if (professor == null) return 0;
            using (var db = new AplicacaoDBContext())
            {
                if (db.Entry<Professor>(professor).State == EntityState.Detached)
                    db.Set<Professor>().Attach(professor);

                db.Entry<Professor>(professor).State = EntityState.Modified;

                return db.SaveChanges();

            }
        }

        public int Excluir(Professor _professor)
        {
            professor = _professor;
            if (professor == null) return 0;
            using (var db = new AplicacaoDBContext())
            {
                if (db.Entry<Professor>(professor).State == EntityState.Detached)
                    db.Set<Professor>().Attach(professor);

                db.Entry<Professor>(professor).State = EntityState.Deleted;

                return db.SaveChanges();

            }
        }
    }
}

