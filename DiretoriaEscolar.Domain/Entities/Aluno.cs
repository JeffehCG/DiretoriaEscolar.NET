using System.Runtime.Serialization;

namespace DiretoriaEscolar.Domain.Entities
{
    [DataContract]
    public class Aluno
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string CPF { get; set; }
        [DataMember]
        public string Telefone { get; set; }
        [DataMember]
        public int TurmaId { get; set; }
        [DataMember]
        public System.DateTime DataNascimento { get; set; }

        [DataMember]
        public virtual Turma Turma { get; set; }
        [DataMember]
        public virtual Endereco EnderecoAluno { get; set; }
    }
}
