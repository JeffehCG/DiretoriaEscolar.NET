﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiretoriaEscolar.WebForms.TurmaService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Turma", Namespace="http://schemas.datacontract.org/2004/07/DiretoriaEscolar.Domain.Entities")]
    [System.SerializableAttribute()]
    public partial class Turma : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DiretoriaEscolar.WebForms.TurmaService.Aluno[] AlunoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClasseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EscolaIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SerieField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DiretoriaEscolar.WebForms.TurmaService.Aluno[] Aluno {
            get {
                return this.AlunoField;
            }
            set {
                if ((object.ReferenceEquals(this.AlunoField, value) != true)) {
                    this.AlunoField = value;
                    this.RaisePropertyChanged("Aluno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ano {
            get {
                return this.AnoField;
            }
            set {
                if ((object.ReferenceEquals(this.AnoField, value) != true)) {
                    this.AnoField = value;
                    this.RaisePropertyChanged("Ano");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Classe {
            get {
                return this.ClasseField;
            }
            set {
                if ((object.ReferenceEquals(this.ClasseField, value) != true)) {
                    this.ClasseField = value;
                    this.RaisePropertyChanged("Classe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EscolaId {
            get {
                return this.EscolaIdField;
            }
            set {
                if ((this.EscolaIdField.Equals(value) != true)) {
                    this.EscolaIdField = value;
                    this.RaisePropertyChanged("EscolaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Serie {
            get {
                return this.SerieField;
            }
            set {
                if ((object.ReferenceEquals(this.SerieField, value) != true)) {
                    this.SerieField = value;
                    this.RaisePropertyChanged("Serie");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Aluno", Namespace="http://schemas.datacontract.org/2004/07/DiretoriaEscolar.Domain.Entities")]
    [System.SerializableAttribute()]
    public partial class Aluno : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CPFField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataNascimentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DiretoriaEscolar.WebForms.TurmaService.Endereco EnderecoAlunoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TurmaIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CPF {
            get {
                return this.CPFField;
            }
            set {
                if ((object.ReferenceEquals(this.CPFField, value) != true)) {
                    this.CPFField = value;
                    this.RaisePropertyChanged("CPF");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataNascimento {
            get {
                return this.DataNascimentoField;
            }
            set {
                if ((this.DataNascimentoField.Equals(value) != true)) {
                    this.DataNascimentoField = value;
                    this.RaisePropertyChanged("DataNascimento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DiretoriaEscolar.WebForms.TurmaService.Endereco EnderecoAluno {
            get {
                return this.EnderecoAlunoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoAlunoField, value) != true)) {
                    this.EnderecoAlunoField = value;
                    this.RaisePropertyChanged("EnderecoAluno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefone {
            get {
                return this.TelefoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefoneField, value) != true)) {
                    this.TelefoneField = value;
                    this.RaisePropertyChanged("Telefone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TurmaId {
            get {
                return this.TurmaIdField;
            }
            set {
                if ((this.TurmaIdField.Equals(value) != true)) {
                    this.TurmaIdField = value;
                    this.RaisePropertyChanged("TurmaId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Endereco", Namespace="http://schemas.datacontract.org/2004/07/DiretoriaEscolar.Domain.Entities")]
    [System.SerializableAttribute()]
    public partial class Endereco : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DiretoriaEscolar.WebForms.TurmaService.Aluno AlunoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BairroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DiretoriaEscolar.WebForms.TurmaService.Escola EscolaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RuaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DiretoriaEscolar.WebForms.TurmaService.Aluno Aluno {
            get {
                return this.AlunoField;
            }
            set {
                if ((object.ReferenceEquals(this.AlunoField, value) != true)) {
                    this.AlunoField = value;
                    this.RaisePropertyChanged("Aluno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Bairro {
            get {
                return this.BairroField;
            }
            set {
                if ((object.ReferenceEquals(this.BairroField, value) != true)) {
                    this.BairroField = value;
                    this.RaisePropertyChanged("Bairro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cidade {
            get {
                return this.CidadeField;
            }
            set {
                if ((object.ReferenceEquals(this.CidadeField, value) != true)) {
                    this.CidadeField = value;
                    this.RaisePropertyChanged("Cidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DiretoriaEscolar.WebForms.TurmaService.Escola Escola {
            get {
                return this.EscolaField;
            }
            set {
                if ((object.ReferenceEquals(this.EscolaField, value) != true)) {
                    this.EscolaField = value;
                    this.RaisePropertyChanged("Escola");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Numero {
            get {
                return this.NumeroField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroField, value) != true)) {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rua {
            get {
                return this.RuaField;
            }
            set {
                if ((object.ReferenceEquals(this.RuaField, value) != true)) {
                    this.RuaField = value;
                    this.RaisePropertyChanged("Rua");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Escola", Namespace="http://schemas.datacontract.org/2004/07/DiretoriaEscolar.Domain.Entities")]
    [System.SerializableAttribute()]
    public partial class Escola : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CNPJField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DiretoriaEscolar.WebForms.TurmaService.Endereco EnderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DiretoriaEscolar.WebForms.TurmaService.Turma[] TurmaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CNPJ {
            get {
                return this.CNPJField;
            }
            set {
                if ((object.ReferenceEquals(this.CNPJField, value) != true)) {
                    this.CNPJField = value;
                    this.RaisePropertyChanged("CNPJ");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DiretoriaEscolar.WebForms.TurmaService.Endereco Endereco {
            get {
                return this.EnderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoField, value) != true)) {
                    this.EnderecoField = value;
                    this.RaisePropertyChanged("Endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DiretoriaEscolar.WebForms.TurmaService.Turma[] Turma {
            get {
                return this.TurmaField;
            }
            set {
                if ((object.ReferenceEquals(this.TurmaField, value) != true)) {
                    this.TurmaField = value;
                    this.RaisePropertyChanged("Turma");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TurmaService.ITurmaAppService")]
    public interface ITurmaAppService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITurmaAppService/Add", ReplyAction="http://tempuri.org/ITurmaAppService/AddResponse")]
        void Add(DiretoriaEscolar.WebForms.TurmaService.Turma obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITurmaAppService/Add", ReplyAction="http://tempuri.org/ITurmaAppService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(DiretoriaEscolar.WebForms.TurmaService.Turma obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITurmaAppService/GetById", ReplyAction="http://tempuri.org/ITurmaAppService/GetByIdResponse")]
        DiretoriaEscolar.WebForms.TurmaService.Turma GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITurmaAppService/GetById", ReplyAction="http://tempuri.org/ITurmaAppService/GetByIdResponse")]
        System.Threading.Tasks.Task<DiretoriaEscolar.WebForms.TurmaService.Turma> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITurmaAppService/GetAll", ReplyAction="http://tempuri.org/ITurmaAppService/GetAllResponse")]
        DiretoriaEscolar.WebForms.TurmaService.Turma[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITurmaAppService/GetAll", ReplyAction="http://tempuri.org/ITurmaAppService/GetAllResponse")]
        System.Threading.Tasks.Task<DiretoriaEscolar.WebForms.TurmaService.Turma[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITurmaAppService/Update", ReplyAction="http://tempuri.org/ITurmaAppService/UpdateResponse")]
        void Update(DiretoriaEscolar.WebForms.TurmaService.Turma obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITurmaAppService/Update", ReplyAction="http://tempuri.org/ITurmaAppService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(DiretoriaEscolar.WebForms.TurmaService.Turma obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITurmaAppService/Remove", ReplyAction="http://tempuri.org/ITurmaAppService/RemoveResponse")]
        void Remove(DiretoriaEscolar.WebForms.TurmaService.Turma obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITurmaAppService/Remove", ReplyAction="http://tempuri.org/ITurmaAppService/RemoveResponse")]
        System.Threading.Tasks.Task RemoveAsync(DiretoriaEscolar.WebForms.TurmaService.Turma obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITurmaAppService/Dispose", ReplyAction="http://tempuri.org/ITurmaAppService/DisposeResponse")]
        void Dispose();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITurmaAppService/Dispose", ReplyAction="http://tempuri.org/ITurmaAppService/DisposeResponse")]
        System.Threading.Tasks.Task DisposeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITurmaAppServiceChannel : DiretoriaEscolar.WebForms.TurmaService.ITurmaAppService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TurmaAppServiceClient : System.ServiceModel.ClientBase<DiretoriaEscolar.WebForms.TurmaService.ITurmaAppService>, DiretoriaEscolar.WebForms.TurmaService.ITurmaAppService {
        
        public TurmaAppServiceClient() {
        }
        
        public TurmaAppServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TurmaAppServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TurmaAppServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TurmaAppServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Add(DiretoriaEscolar.WebForms.TurmaService.Turma obj) {
            base.Channel.Add(obj);
        }
        
        public System.Threading.Tasks.Task AddAsync(DiretoriaEscolar.WebForms.TurmaService.Turma obj) {
            return base.Channel.AddAsync(obj);
        }
        
        public DiretoriaEscolar.WebForms.TurmaService.Turma GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<DiretoriaEscolar.WebForms.TurmaService.Turma> GetByIdAsync(int id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public DiretoriaEscolar.WebForms.TurmaService.Turma[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<DiretoriaEscolar.WebForms.TurmaService.Turma[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public void Update(DiretoriaEscolar.WebForms.TurmaService.Turma obj) {
            base.Channel.Update(obj);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(DiretoriaEscolar.WebForms.TurmaService.Turma obj) {
            return base.Channel.UpdateAsync(obj);
        }
        
        public void Remove(DiretoriaEscolar.WebForms.TurmaService.Turma obj) {
            base.Channel.Remove(obj);
        }
        
        public System.Threading.Tasks.Task RemoveAsync(DiretoriaEscolar.WebForms.TurmaService.Turma obj) {
            return base.Channel.RemoveAsync(obj);
        }
        
        public void Dispose() {
            base.Channel.Dispose();
        }
        
        public System.Threading.Tasks.Task DisposeAsync() {
            return base.Channel.DisposeAsync();
        }
    }
}
