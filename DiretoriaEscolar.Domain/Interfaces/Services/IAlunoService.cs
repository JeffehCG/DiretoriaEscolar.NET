using DiretoriaEscolar.Domain.Entities;
using System.Collections.Generic;

namespace DiretoriaEscolar.Domain.Interfaces.Services
{
    public interface IAlunoService
    {
        void Add(Aluno obj);
        void Update(Aluno obj);
        void Remove(Aluno obj);
        Aluno GetById(int id);
        IEnumerable<Aluno> GetAll();
        void Dispose();
    }
}
