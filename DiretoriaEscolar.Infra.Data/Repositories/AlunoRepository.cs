using DiretoriaEscolar.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DiretoriaEscolar.Infra.Data.Repositories
{
    public class AlunoRepository : IDisposable, IAlunoRepository
    {
        protected DiretoriaModelContainer Db = new DiretoriaModelContainer();
        public void Add(Domain.Entities.Aluno obj)
        {
            Db.Set<Domain.Entities.Aluno>().Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Entities.Aluno> GetAll()
        {
            return Db.Set<Domain.Entities.Aluno>().ToList();
        }

        public Domain.Entities.Aluno GetById(int id)
        {
            return Db.Set<Domain.Entities.Aluno>().Find(id);
        }

        public void Remove(Domain.Entities.Aluno obj)
        {
            Db.Entry(obj).State = EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Update(Domain.Entities.Aluno obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
