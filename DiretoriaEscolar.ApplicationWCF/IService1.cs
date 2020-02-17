using DiretoriaEscolar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DiretoriaEscolar.ApplicationWCF
{
    [ServiceContract]
    public interface IService1
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
