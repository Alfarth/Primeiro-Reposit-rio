using Academia.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Academia.Repository
{
    class RepositorioModalidade
    {
        Modalidade modalidade;

        public int Adicionar (Modalidade _modalidade)
        {
            modalidade = _modalidade;
            if (modalidade == null) return 0;
            using (var db = new AplicacaoDBContext())
            {
                if (db.Entry<Modalidade>(modalidade).State == EntityState.Detached)
                    db.Set<Modalidade>().Attach(modalidade);

                db.Entry<Modalidade>(modalidade).State = EntityState.Added;

                return db.SaveChanges();

            }
        }

        public int Atualizar(Modalidade _modalidade)
        {
            modalidade = _modalidade;
            if (modalidade == null) return 0;
            using (var db = new AplicacaoDBContext())
            {
                if (db.Entry<Modalidade>(modalidade).State == EntityState.Detached)
                    db.Set<Modalidade>().Attach(modalidade);

                db.Entry<Modalidade>(modalidade).State = EntityState.Modified;

                return db.SaveChanges();

            }
        }

        public  int Excluir(Modalidade _modalidade)
        {
            modalidade = _modalidade;
            if (modalidade == null) return 0;
            using (var db = new AplicacaoDBContext())
            {
                if (db.Entry<Modalidade>(modalidade).State == EntityState.Detached)
                    db.Set<Modalidade>().Attach(modalidade);

                db.Entry<Modalidade>(modalidade).State = EntityState.Deleted;

                return db.SaveChanges();

            }
        }
    }


}
