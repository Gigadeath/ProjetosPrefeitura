
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/08/2017 09:38:53
-- Generated from EDMX file: C:\Users\Administrador\Documents\GitHub\ProjetosPrefeitura\GeraçãoUnidades\GeraçãoUnidades\Unidades\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Unidades];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UnidadesSet'
CREATE TABLE [dbo].[UnidadesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SECRETARIA] nvarchar(max)  NOT NULL,
    [AGRUPAMENTO] nvarchar(max)  NOT NULL,
    [SUBPREFEITURA] nvarchar(max)  NOT NULL,
    [ADMREGIONAL] nvarchar(max)  NOT NULL,
    [DRE] nvarchar(max)  NOT NULL,
    [TIPOUNIDADE] nvarchar(max)  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CODUND] nvarchar(max)  NOT NULL,
    [NOMEUNIDADE] nvarchar(max)  NOT NULL,
    [ENDEREÇO] nvarchar(max)  NOT NULL,
    [TELEFONE] nvarchar(max)  NOT NULL,
    [CEP] nvarchar(max)  NOT NULL,
    [BAIRRO] nvarchar(max)  NOT NULL,
    [INICIOCONVENIO] nvarchar(max)  NOT NULL,
    [FIMCONVENIO] nvarchar(max)  NOT NULL,
    [TIPOATENDIMENTO] nvarchar(max)  NOT NULL,
    [INICIODESATIVACAO] nvarchar(max)  NOT NULL,
    [FIMDESATIVACAO] nvarchar(max)  NOT NULL,
    [CODIGOEOL] nvarchar(max)  NOT NULL,
    [INAUGURADO] nvarchar(max)  NOT NULL,
    [INICIOTIPOATENDIMENTO] nvarchar(max)  NOT NULL,
    [FIMTIPOATENDIMENTO] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UnidadesSet'
ALTER TABLE [dbo].[UnidadesSet]
ADD CONSTRAINT [PK_UnidadesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
--CONFIGURING SQL INSTANCE TO ACCEPT ADVANCED OPTIONS
EXEC sp_configure 'show advanced options', 1
RECONFIGURE
GO

--ENABLING USE OF DISTRIBUTED QUERIES
EXEC sp_configure 'Ad Hoc Distributed Queries', 1
RECONFIGURE
GO
--ADD DRIVERS IN SQL INSTANCE
EXEC Unidades.dbo.sp_MSset_oledb_prop N'Microsoft.ACE.OLEDB.12.0', N'AllowInProcess', 1
GO

EXEC Unidades.dbo.sp_MSset_oledb_prop N'Microsoft.ACE.OLEDB.12.0', N'DynamicParameters', 1
GO
--CONSULTING A SPREADSHEET
SELECT * FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0',
'Excel 12.0; Database=C:\Unidades.xlsx; HDR=YES; IMEX=1',
'SELECT * FROM [Plan4$]') 
GO

SELECT * 
INTO Unidades
FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0',
'Excel 12.0; Database=C:\Unidades.xlsx; HDR=YES; IMEX=1',
'SELECT * FROM [Plan4$]') 
GO

SELECT * FROM Unidades
GO