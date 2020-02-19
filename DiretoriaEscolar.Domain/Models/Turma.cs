using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DiretoriaEscolar.Domain.Entities
{
    [DataContract]
    public class Turma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Turma()
        {
            this.Aluno = new HashSet<Aluno>();
        }

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
        public virtual Escola Escola { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<Aluno> Aluno { get; set; }
    }
}
