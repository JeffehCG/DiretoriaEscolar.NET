using System.Runtime.Serialization;

namespace DiretoriaEscolar.Domain.Entities
{
    [DataContract]
    public class Endereco
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public string Cidade { get; set; }
        [DataMember]
        public string Bairro { get; set; }
        [DataMember]
        public string Rua { get; set; }
        [DataMember]
        public string Numero { get; set; }

        [DataMember]
        public virtual Aluno Aluno { get; set; }
        [DataMember]
        public virtual Escola Escola { get; set; }
    }
}
