using DiretoriaEscolar.Domain.Entities;
using System.Collections.Generic;

namespace DiretoriaEscolar.Domain.Interfaces.Repositories
{
    public interface IEnderecoRepository
    {
        void Add(Endereco obj);
        void Update(Endereco obj);
        void Remove(Endereco obj);
        Endereco GetById(int id);
        IEnumerable<Endereco> GetAll();
        void Dispose();
    }
}
