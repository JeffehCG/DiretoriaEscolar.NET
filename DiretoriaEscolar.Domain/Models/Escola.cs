using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DiretoriaEscolar.Domain.Entities
{
    [DataContract]
    public class Escola
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string CNPJ { get; set; }
        [DataMember]
        public virtual ICollection<Turma> Turma { get; set; }
        [DataMember]
        public virtual Endereco Endereco { get; set; }
    }
}
