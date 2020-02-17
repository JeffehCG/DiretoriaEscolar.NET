using DiretoriaEscolar.Domain.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace DiretoriaEscolar.Application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAlunoAppService" in both code and config file together.
    [ServiceContract]
    public interface IAlunoAppService
    {
        [OperationContract]
        void Add(Aluno obj);

        [OperationContract]
        Aluno GetById(int id);

        [OperationContract]
        IEnumerable<Aluno> GetAll();

        [OperationContract]
        void Update(Aluno obj);

        [OperationContract]
        void Remove(Aluno obj);

        [OperationContract]
        void Dispose();
    }
}
