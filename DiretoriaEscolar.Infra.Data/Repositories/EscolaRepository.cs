using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Repositories;
using DiretoriaEscolar.Infra.Data.AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DiretoriaEscolar.Infra.Data.Repositories
{
    public class EscolaRepository : IDisposable, IEscolaRepository
    {
        protected DiretoriaModelContainer Db = new DiretoriaModelContainer();
        private AutoMapperConfig<Escola, Escolas> _mapper = new AutoMapperConfig<Escola, Escolas>();
        public void Add(Escola obj)
        {
            Db.Set<Escolas>().Add(_mapper.MapClass(obj));
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Escola> GetAll()
        {
            var escolasData = Db.Set<Escolas>().ToList();
            List<Escola> escolaDomain = new List<Escola>();
            foreach (var item in escolasData)
            {
                escolaDomain.Add(_mapper.MapClass(item));
            }
            return escolaDomain;
        }

        public Escola GetById(int id)
        {
            return _mapper.MapClass(Db.Set<Escolas>().Find(id));
        }

        public void Remove(Escola obj)
        {
            Db.Entry(_mapper.MapClass(obj)).State = EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Update(Escola obj)
        {
            Db.Entry(_mapper.MapClass(obj)).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
