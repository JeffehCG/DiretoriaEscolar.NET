
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/16/2020 16:59:01
-- Generated from EDMX file: C:\Users\dezje\Documents\DiretoriaEscolar\DiretoriaEscolar.Infra.Data\DiretoriaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Diretoria];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EscolaTurma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Turma] DROP CONSTRAINT [FK_EscolaTurma];
GO
IF OBJECT_ID(N'[dbo].[FK_TurmaAluno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aluno] DROP CONSTRAINT [FK_TurmaAluno];
GO
IF OBJECT_ID(N'[dbo].[FK_AlunoEnderecoAluno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EnderecoAlunoSet] DROP CONSTRAINT [FK_AlunoEnderecoAluno];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Escola]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Escola];
GO
IF OBJECT_ID(N'[dbo].[Aluno]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aluno];
GO
IF OBJECT_ID(N'[dbo].[Turma]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Turma];
GO
IF OBJECT_ID(N'[dbo].[EnderecoAlunoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EnderecoAlunoSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Escola'
CREATE TABLE [dbo].[Escola] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CNPJ] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Aluno'
CREATE TABLE [dbo].[Aluno] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CPF] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [TurmaId] int  NOT NULL,
    [DataNascimento] datetime  NOT NULL
);
GO

-- Creating table 'Turma'
CREATE TABLE [dbo].[Turma] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ano] nvarchar(max)  NOT NULL,
    [Serie] nvarchar(max)  NOT NULL,
    [Classe] nvarchar(max)  NOT NULL,
    [EscolaId] int  NOT NULL
);
GO

-- Creating table 'EnderecoSet'
CREATE TABLE [dbo].[EnderecoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [Bairro] nvarchar(max)  NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [Aluno_Id] int  NULL,
    [Escola_Id] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Escola'
ALTER TABLE [dbo].[Escola]
ADD CONSTRAINT [PK_Escola]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Aluno'
ALTER TABLE [dbo].[Aluno]
ADD CONSTRAINT [PK_Aluno]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Turma'
ALTER TABLE [dbo].[Turma]
ADD CONSTRAINT [PK_Turma]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EnderecoSet'
ALTER TABLE [dbo].[EnderecoSet]
ADD CONSTRAINT [PK_EnderecoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EscolaId] in table 'Turma'
ALTER TABLE [dbo].[Turma]
ADD CONSTRAINT [FK_EscolaTurma]
    FOREIGN KEY ([EscolaId])
    REFERENCES [dbo].[Escola]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EscolaTurma'
CREATE INDEX [IX_FK_EscolaTurma]
ON [dbo].[Turma]
    ([EscolaId]);
GO

-- Creating foreign key on [TurmaId] in table 'Aluno'
ALTER TABLE [dbo].[Aluno]
ADD CONSTRAINT [FK_TurmaAluno]
    FOREIGN KEY ([TurmaId])
    REFERENCES [dbo].[Turma]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TurmaAluno'
CREATE INDEX [IX_FK_TurmaAluno]
ON [dbo].[Aluno]
    ([TurmaId]);
GO

-- Creating foreign key on [Aluno_Id] in table 'EnderecoSet'
ALTER TABLE [dbo].[EnderecoSet]
ADD CONSTRAINT [FK_AlunoEnderecoAluno]
    FOREIGN KEY ([Aluno_Id])
    REFERENCES [dbo].[Aluno]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlunoEnderecoAluno'
CREATE INDEX [IX_FK_AlunoEnderecoAluno]
ON [dbo].[EnderecoSet]
    ([Aluno_Id]);
GO

-- Creating foreign key on [Escola_Id] in table 'EnderecoSet'
ALTER TABLE [dbo].[EnderecoSet]
ADD CONSTRAINT [FK_EscolaEndereco]
    FOREIGN KEY ([Escola_Id])
    REFERENCES [dbo].[Escola]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EscolaEndereco'
CREATE INDEX [IX_FK_EscolaEndereco]
ON [dbo].[EnderecoSet]
    ([Escola_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------