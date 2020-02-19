using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DiretoriaEscolar.Domain.Entities
{
    [DataContract]
    public class Escola
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Escola()
        {
            this.Turma = new HashSet<Turma>();
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string CNPJ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<Turma> Turma { get; set; }
        [DataMember]
        public virtual Endereco Endereco { get; set; }
    }
}
