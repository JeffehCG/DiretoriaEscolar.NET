using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Repositories;
using DiretoriaEscolar.Infra.Data.AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DiretoriaEscolar.Infra.Data.Repositories
{
    public class EnderecoRepository : IDisposable, IEnderecoRepository
    {
        protected DiretoriaModelContainer Db = new DiretoriaModelContainer();
        private AutoMapperConfig<Endereco, Enderecos> _mapper = new AutoMapperConfig<Endereco, Enderecos>();
        public void Add(Endereco obj)
        {
            Db.Set<Enderecos>().Add(_mapper.MapClass(obj));
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Endereco> GetAll()
        {
            var enderecosData = Db.Set<Enderecos>().ToList();
            List<Endereco> enderecoDomain = new List<Endereco>();
            foreach (var item in enderecosData)
            {
                enderecoDomain.Add(_mapper.MapClass(item));
            }
            return enderecoDomain;
        }

        public Endereco GetById(int id)
        {
            return _mapper.MapClass(Db.Set<Enderecos>().Find(id));
        }

        public void Remove(Endereco obj)
        {
            Db.Entry(_mapper.MapClass(obj)).State = EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Update(Endereco obj)
        {
            Db.Entry(_mapper.MapClass(obj)).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
