using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Repositories;
using DiretoriaEscolar.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace DiretoriaEscolar.Domain.Services
{
    public class EscolaService : IDisposable, IEscolaService
    {
        private readonly IEscolaRepository _escolaRepository;
        public EscolaService(IEscolaRepository escolaRepository)
        {
            _escolaRepository = escolaRepository;
        }
        public void Add(Escola obj)
        {
            _escolaRepository.Add(obj);
        }

        public void Dispose()
        {
            _escolaRepository.Dispose();
        }

        public IEnumerable<Escola> GetAll()
        {
            return _escolaRepository.GetAll();
        }

        public Escola GetById(int id)
        {
            return _escolaRepository.GetById(id);
        }

        public void Remove(Escola obj)
        {
            _escolaRepository.Remove(obj);
        }

        public void Update(Escola obj)
        {
            _escolaRepository.Update(obj);
        }
    }
}
