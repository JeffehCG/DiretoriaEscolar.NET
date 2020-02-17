using DiretoriaEscolar.Domain.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace DiretoriaEscolar.Application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITurmaAppService" in both code and config file together.
    [ServiceContract]
    public interface ITurmaAppService
    {
        [OperationContract]
        void Add(Turma obj);

        [OperationContract]
        Turma GetById(int id);

        [OperationContract]
        IEnumerable<Turma> GetAll();

        [OperationContract]
        void Update(Turma obj);

        [OperationContract]
        void Remove(Turma obj);

        [OperationContract]
        void Dispose();
    }
}
