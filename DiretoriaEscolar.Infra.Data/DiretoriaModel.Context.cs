﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiretoriaEscolar.Infra.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using DiretoriaEscolar.Domain.Entities;
    
    public partial class DiretoriaModelContainer : DbContext
    {
        public DiretoriaModelContainer()
            : base("name=DiretoriaModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Escola> Escola { get; set; }
        public virtual DbSet<Aluno> Aluno { get; set; }
        public virtual DbSet<Turma> Turma { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
    }
}
