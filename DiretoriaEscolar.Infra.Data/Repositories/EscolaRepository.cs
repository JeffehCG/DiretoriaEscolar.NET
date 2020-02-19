using DiretoriaEscolar.Domain.Entities;
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
        public void Add(Escola obj)
        {
            Db.Set<Escola>().Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Escola> GetAll()
        {
            return Db.Set<Escola>().ToList();
        }

        public Escola GetById(int id)
        {
            return Db.Set<Escola>().Find(id);
        }

        public void Remove(Escola obj)
        {
            Db.Entry(obj).State = EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Update(Escola obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
