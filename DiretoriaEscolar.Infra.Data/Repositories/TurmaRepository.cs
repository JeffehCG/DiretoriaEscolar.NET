using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Repositories;
using DiretoriaEscolar.Infra.Data.AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DiretoriaEscolar.Infra.Data.Repositories
{
    public class TurmaRepository : IDisposable, ITurmaRepository
    {
        DiretoriaModelContainer Db = new DiretoriaModelContainer();
        private AutoMapperConfig<Turma, Turmas> _mapper = new AutoMapperConfig<Turma, Turmas>();
        public void Add(Turma obj)
        {
            Db.Set<Turmas>().Add(_mapper.MapClass(obj));
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Turma> GetAll()
        {
            var turmasData = Db.Set<Turmas>().ToList();
            List<Turma> turmaDomain = new List<Turma>();
            foreach (var item in turmasData)
            {
                turmaDomain.Add(_mapper.MapClass(item));
            }
            return turmaDomain;
        }

        public Turma GetById(int id)
        {
            return _mapper.MapClass(Db.Set<Turmas>().Find(id));
        }

        public void Remove(Turma obj)
        {
            Db.Entry(_mapper.MapClass(obj)).State = EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Update(Turma obj)
        {
            Db.Entry(_mapper.MapClass(obj)).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
