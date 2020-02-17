using DiretoriaEscolar.Domain.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace DiretoriaEscolar.Application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEnderecoAppService" in both code and config file together.
    [ServiceContract]
    public interface IEnderecoAppService
    {
        [OperationContract]
        void Add(Endereco obj);

        [OperationContract]
        Endereco GetById(int id);

        [OperationContract]
        IEnumerable<Endereco> GetAll();

        [OperationContract]
        void Update(Endereco obj);

        [OperationContract]
        void Remove(Endereco obj);

        [OperationContract]
        void Dispose();
    }
}
