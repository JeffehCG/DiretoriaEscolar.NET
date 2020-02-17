using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Repositories;
using DiretoriaEscolar.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace DiretoriaEscolar.Domain.Services
{
    public class AlunoService : IDisposable, IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public void Add(Aluno obj)
        {
            _alunoRepository.Add(obj);
        }

        public void Dispose()
        {
            _alunoRepository.Dispose();
        }

        public IEnumerable<Aluno> GetAll()
        {
            return _alunoRepository.GetAll();
        }

        public Aluno GetById(int id)
        {
            return _alunoRepository.GetById(id);
        }

        public void Remove(Aluno obj)
        {
            _alunoRepository.Remove(obj);
        }

        public void Update(Aluno obj)
        {
            _alunoRepository.Update(obj);
        }
    }
}
