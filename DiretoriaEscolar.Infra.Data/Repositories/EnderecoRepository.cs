using DiretoriaEscolar.Domain.Entities;
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
        public void Add(Endereco obj)
        {
            Db.Set<Endereco>().Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Endereco> GetAll()
        {
            return Db.Set<Endereco>().ToList();
        }

        public Endereco GetById(int id)
        {
            return Db.Set<Endereco>().Find(id);
        }

        public void Remove(Endereco obj)
        {
            Db.Entry(obj).State = EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Update(Endereco obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
