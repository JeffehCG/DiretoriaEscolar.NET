using DiretoriaEscolar.Domain.Entities;
using System.Collections.Generic;

namespace DiretoriaEscolar.Domain.Interfaces.Repositories
{
    public interface IEscolaRepository
    {
        void Add(Escola obj);
        void Dispose();
        IEnumerable<Escola> GetAll();
        Escola GetById(int id);
        void Remove(Escola obj);
        void Update(Escola obj);
    }
}
