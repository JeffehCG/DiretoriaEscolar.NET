using DiretoriaEscolar.Domain.Entities;
using System.Collections.Generic;

namespace DiretoriaEscolar.Domain.Interfaces.Services
{
    public interface ITurmaService
    {
        void Add(Turma obj);
        void Update(Turma obj);
        void Remove(Turma obj);
        Turma GetById(int id);
        IEnumerable<Turma> GetAll();
        void Dispose();
    }
}
