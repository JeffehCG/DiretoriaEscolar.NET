using DiretoriaEscolar.Domain.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace DiretoriaEscolar.Application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEscolaAppService" in both code and config file together.
    [ServiceContract]
    public interface IEscolaAppService
    {
        [OperationContract]
        void Add(Escola obj);

        [OperationContract]
        Escola GetById(int id);

        [OperationContract]
        IEnumerable<Escola> GetAll();

        [OperationContract]
        void Update(Escola obj);

        [OperationContract]
        void Remove(Escola obj);

        [OperationContract]
        void Dispose();
    }
}
