using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DiretoriaEscolar.Application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EscolaAppService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EscolaAppService.svc or EscolaAppService.svc.cs at the Solution Explorer and start debugging.
    public class EscolaAppService : IEscolaAppService
    {
        private readonly IEscolaService _escolaService;
        public EscolaAppService(IEscolaService escolaService)
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
