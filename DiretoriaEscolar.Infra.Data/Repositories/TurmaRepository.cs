using DiretoriaEscolar.Domain.Entities;
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
        public void Add(Turma obj)
        {
            Db.Set<Turma>().Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Turma> GetAll()
        {
            return Db.Set<Turma>().ToList();
        }

        public Turma GetById(int id)
        {
            return Db.Set<Turma>().Find(id);
        }

        public void Remove(Turma obj)
        {
            Db.Entry(obj).State = EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Update(Turma obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
