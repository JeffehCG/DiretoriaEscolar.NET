using DiretoriaEscolar.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DiretoriaEscolar.Infra.Data.Repositories
{
    public class EscolaRepository : IDisposable, IEscolaRepository
    {
        protected DiretoriaModelContainer Db = new DiretoriaModelContainer();
        public void Add(Domain.Entities.Escola obj)
        {
            Db.Set<Domain.Entities.Escola>().Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Entities.Escola> GetAll()
        {
            return Db.Set<Domain.Entities.Escola>().ToList();
        }

        public Domain.Entities.Escola GetById(int id)
        {
            return Db.Set<Domain.Entities.Escola>().Find(id);
        }

        public void Remove(Domain.Entities.Escola obj)
        {
            Db.Entry(obj).State = EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Update(Domain.Entities.Escola obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
