using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Repositories;
using DiretoriaEscolar.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace DiretoriaEscolar.Domain.Services
{
    public class EnderecoService : IDisposable, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
        public void Add(Endereco obj)
        {
            _enderecoRepository.Add(obj);
        }

        public void Dispose()
        {
            _enderecoRepository.Dispose();
        }

        public IEnumerable<Endereco> GetAll()
        {
            return _enderecoRepository.GetAll();
        }

        public Endereco GetById(int id)
        {
            return _enderecoRepository.GetById(id);
        }

        public void Remove(Endereco obj)
        {
            _enderecoRepository.Remove(obj);
        }

        public void Update(Endereco obj)
        {
            _enderecoRepository.Update(obj);
        }
    }
}
