using DiretoriaEscolar.Domain.Entities;
using System.Collections.Generic;

namespace DiretoriaEscolar.Domain.Interfaces.Services
{
    public interface IEscolaService
    {
        void Add(Escola obj);
        void Dispose();
        IEnumerable<Escola> GetAll();
        Escola GetById(int id);
        void Remove(Escola obj);
        void Update(Escola obj);
    }
}
