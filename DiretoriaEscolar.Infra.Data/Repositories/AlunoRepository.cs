using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Repositories;
using DiretoriaEscolar.Infra.Data.AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DiretoriaEscolar.Infra.Data.Repositories
{
    public class AlunoRepository : IDisposable, IAlunoRepository
    {
        protected DiretoriaModelContainer Db = new DiretoriaModelContainer();
        private AutoMapperConfig<Aluno, Alunos> _mapper = new AutoMapperConfig<Aluno, Alunos>();
        public void Add(Aluno obj)
        {
            Db.Set<Alunos>().Add(_mapper.MapClass(obj));
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> GetAll()
        {
            var alunosData = Db.Set<Alunos>().ToList();
            List<Aluno> alunosDomain = new List<Aluno>();
            foreach (var item in alunosData)
            {
                alunosDomain.Add(_mapper.MapClass(item));
            }
            return alunosDomain;
        }

        public Aluno GetById(int id)
        {
            return _mapper.MapClass(Db.Set<Alunos>().Find(id));
        }

        public void Remove(Aluno obj)
        {
            Db.Entry(_mapper.MapClass(obj)).State = EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Update(Aluno obj)
        {
            Db.Entry(_mapper.MapClass(obj)).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
