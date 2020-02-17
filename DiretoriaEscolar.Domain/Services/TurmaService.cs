using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Repositories;
using DiretoriaEscolar.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace DiretoriaEscolar.Domain.Services
{
    public class TurmaService : IDisposable, ITurmaService
    {
        private readonly ITurmaRepository _turmaRepository;
        public TurmaService(ITurmaRepository turmaRepository)
        {
            _turmaRepository = turmaRepository;
        }
        public void Add(Turma obj)
        {
            _turmaRepository.Add(obj);
        }

        public void Dispose()
        {
            _turmaRepository.Dispose();
        }

        public IEnumerable<Turma> GetAll()
        {
            return _turmaRepository.GetAll();
        }

        public Turma GetById(int id)
        {
            return _turmaRepository.GetById(id);
        }

        public void Remove(Turma obj)
        {
            _turmaRepository.Remove(obj);
        }

        public void Update(Turma obj)
        {
            _turmaRepository.Update(obj);
        }
    }
}
