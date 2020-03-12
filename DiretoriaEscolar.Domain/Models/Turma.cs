using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DiretoriaEscolar.Domain.Entities
{
    [DataContract]
    public class Turma
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Ano { get; set; }
        [DataMember]
        public string Serie { get; set; }
        [DataMember]
        public string Classe { get; set; }
        [DataMember]
        public int EscolaId { get; set; }
        [DataMember]
        public virtual ICollection<Aluno> Aluno { get; set; }
    }
}
