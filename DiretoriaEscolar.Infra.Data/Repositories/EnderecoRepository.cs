using DiretoriaEscolar.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DiretoriaEscolar.Infra.Data.Repositories
{
    public class EnderecoRepository : IDisposable, IEnderecoRepository
    {
        protected DiretoriaModelContainer Db = new DiretoriaModelContainer();
        public void Add(Domain.Entities.Endereco obj)
        {
            Db.Set<Domain.Entities.Endereco>().Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Entities.Endereco> GetAll()
        {
            return Db.Set<Domain.Entities.Endereco>().ToList();
        }

        public Domain.Entities.Endereco GetById(int id)
        {
            return Db.Set<Domain.Entities.Endereco>().Find(id);
        }

        public void Remove(Domain.Entities.Endereco obj)
        {
            Db.Entry(obj).State = EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Update(Domain.Entities.Endereco obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
