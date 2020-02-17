using DiretoriaEscolar.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DiretoriaEscolar.Infra.Data.Repositories
{
    public class TurmaRepository : IDisposable, ITurmaRepository
    {
        DiretoriaModelContainer Db = new DiretoriaModelContainer();
        public void Add(Domain.Entities.Turma obj)
        {
            Db.Set<Domain.Entities.Turma>().Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Entities.Turma> GetAll()
        {
            return Db.Set<Domain.Entities.Turma>().ToList();
        }

        public Domain.Entities.Turma GetById(int id)
        {
            return Db.Set<Domain.Entities.Turma>().Find(id);
        }

        public void Remove(Domain.Entities.Turma obj)
        {
            Db.Entry(obj).State = EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Update(Domain.Entities.Turma obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
