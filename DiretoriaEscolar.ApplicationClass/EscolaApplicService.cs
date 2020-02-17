using DiretoriaEscolar.ApplicationClass.Interfaces;
using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiretoriaEscolar.ApplicationClass
{
    public class EscolaApplicService : IEscolaApplicService
    {
        private readonly IEscolaService _escolaService;
        public EscolaApplicService(IEscolaService escolaService)
        {
            _escolaService = escolaService;
        }
        public void Add(Escola obj)
        {
            _escolaService.Add(obj);
        }

        public void Dispose()
        {
            _escolaService.Dispose();
        }

        public IEnumerable<Escola> GetAll()
        {
            return _escolaService.GetAll();
        }

        public Escola GetById(int id)
        {
            return _escolaService.GetById(id);
        }

        public void Remove(Escola obj)
        {
            _escolaService.Remove(obj);
        }

        public void Update(Escola obj)
        {
            _escolaService.Update(obj);
        }
    }
}
