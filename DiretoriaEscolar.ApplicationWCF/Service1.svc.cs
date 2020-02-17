using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DiretoriaEscolar.ApplicationWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private readonly IEscolaService _escolaService;
        public Service1(IEscolaService escolaService)
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
