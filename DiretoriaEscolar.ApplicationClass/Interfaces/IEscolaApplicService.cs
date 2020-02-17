using DiretoriaEscolar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiretoriaEscolar.ApplicationClass.Interfaces
{
    public interface IEscolaApplicService
    {
        void Add(Escola obj);
        void Dispose();
        IEnumerable<Escola> GetAll();
        Escola GetById(int id);
        void Remove(Escola obj);
        void Update(Escola obj);
    }
}
