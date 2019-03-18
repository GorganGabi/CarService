
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/18/2019 19:47:52
-- Generated from EDMX file: F:\Proiecte\Visual Studio Projects\C#\TSP.NET\CarService\ModelDesignFirst_L1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClientComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clienti] DROP CONSTRAINT [FK_ClientComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_AutoComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Autoes] DROP CONSTRAINT [FK_AutoComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientAuto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clienti] DROP CONSTRAINT [FK_ClientAuto];
GO
IF OBJECT_ID(N'[dbo].[FK_ComandaDetaliuComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comenzi] DROP CONSTRAINT [FK_ComandaDetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaMecanic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mecanici] DROP CONSTRAINT [FK_DetaliuComandaMecanic];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaOperatie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Operatii] DROP CONSTRAINT [FK_DetaliuComandaOperatie];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaMaterial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Materiale] DROP CONSTRAINT [FK_DetaliuComandaMaterial];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaImagine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Imagini] DROP CONSTRAINT [FK_DetaliuComandaImagine];
GO
IF OBJECT_ID(N'[dbo].[FK_AutoSasiu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Autoes] DROP CONSTRAINT [FK_AutoSasiu];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clienti]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clienti];
GO
IF OBJECT_ID(N'[dbo].[Autoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Autoes];
GO
IF OBJECT_ID(N'[dbo].[Mecanici]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mecanici];
GO
IF OBJECT_ID(N'[dbo].[Materiale]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Materiale];
GO
IF OBJECT_ID(N'[dbo].[Imagini]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Imagini];
GO
IF OBJECT_ID(N'[dbo].[Operatii]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Operatii];
GO
IF OBJECT_ID(N'[dbo].[Comenzi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comenzi];
GO
IF OBJECT_ID(N'[dbo].[DetaliuComenzi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetaliuComenzi];
GO
IF OBJECT_ID(N'[dbo].[Sasius]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sasius];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clienti'
CREATE TABLE [dbo].[Clienti] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [Adresa] nvarchar(50)  NOT NULL,
    [Localitate] nvarchar(10)  NOT NULL,
    [Judet] nvarchar(10)  NOT NULL,
    [Telefon] decimal(13,0)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [Comanda_Id] int  NOT NULL
);
GO

-- Creating table 'Autoes'
CREATE TABLE [dbo].[Autoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NumarAuto] nvarchar(10)  NOT NULL,
    [SerieSasiu] nvarchar(25)  NOT NULL,
    [Comanda_Id] int  NOT NULL,
    [Client_Id] int  NOT NULL,
    [Sasiu_Id] int  NOT NULL
);
GO

-- Creating table 'Mecanici'
CREATE TABLE [dbo].[Mecanici] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [DetaliuComanda_Id] int  NOT NULL
);
GO

-- Creating table 'Materiale'
CREATE TABLE [dbo].[Materiale] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(50)  NOT NULL,
    [Cantitate] decimal(18,0)  NOT NULL,
    [Pret] decimal(18,0)  NOT NULL,
    [DataAprovizionare] datetime  NOT NULL,
    [DetaliuComanda_Id] int  NOT NULL
);
GO

-- Creating table 'Imagini'
CREATE TABLE [dbo].[Imagini] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Titlu] nvarchar(15)  NOT NULL,
    [Descriere] nvarchar(256)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Foto] varbinary(max)  NOT NULL,
    [DetaliuComanda_Id] int  NOT NULL
);
GO

-- Creating table 'Operatii'
CREATE TABLE [dbo].[Operatii] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(256)  NOT NULL,
    [TimpExecutie] decimal(6,2)  NOT NULL,
    [DetaliuComanda_Id] int  NOT NULL
);
GO

-- Creating table 'Comenzi'
CREATE TABLE [dbo].[Comenzi] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StareComanda] int  NOT NULL,
    [DataSystem] nvarchar(max)  NOT NULL,
    [DataProgramare] datetime  NOT NULL,
    [DataFinalizare] datetime  NOT NULL,
    [KmBord] int  NOT NULL,
    [Descriere] nvarchar(1024)  NOT NULL,
    [ValoarePise] decimal(10,2)  NOT NULL,
    [DetaliuComanda_Id] int  NOT NULL
);
GO

-- Creating table 'DetaliuComenzi'
CREATE TABLE [dbo].[DetaliuComenzi] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Sasius'
CREATE TABLE [dbo].[Sasius] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodSasiu] nchar(2)  NOT NULL,
    [Denumire] nvarchar(25)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clienti'
ALTER TABLE [dbo].[Clienti]
ADD CONSTRAINT [PK_Clienti]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Autoes'
ALTER TABLE [dbo].[Autoes]
ADD CONSTRAINT [PK_Autoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Mecanici'
ALTER TABLE [dbo].[Mecanici]
ADD CONSTRAINT [PK_Mecanici]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Materiale'
ALTER TABLE [dbo].[Materiale]
ADD CONSTRAINT [PK_Materiale]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Imagini'
ALTER TABLE [dbo].[Imagini]
ADD CONSTRAINT [PK_Imagini]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Operatii'
ALTER TABLE [dbo].[Operatii]
ADD CONSTRAINT [PK_Operatii]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [PK_Comenzi]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetaliuComenzi'
ALTER TABLE [dbo].[DetaliuComenzi]
ADD CONSTRAINT [PK_DetaliuComenzi]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sasius'
ALTER TABLE [dbo].[Sasius]
ADD CONSTRAINT [PK_Sasius]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Comanda_Id] in table 'Clienti'
ALTER TABLE [dbo].[Clienti]
ADD CONSTRAINT [FK_ClientComanda]
    FOREIGN KEY ([Comanda_Id])
    REFERENCES [dbo].[Comenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientComanda'
CREATE INDEX [IX_FK_ClientComanda]
ON [dbo].[Clienti]
    ([Comanda_Id]);
GO

-- Creating foreign key on [Comanda_Id] in table 'Autoes'
ALTER TABLE [dbo].[Autoes]
ADD CONSTRAINT [FK_AutoComanda]
    FOREIGN KEY ([Comanda_Id])
    REFERENCES [dbo].[Comenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoComanda'
CREATE INDEX [IX_FK_AutoComanda]
ON [dbo].[Autoes]
    ([Comanda_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'Autoes'
ALTER TABLE [dbo].[Autoes]
ADD CONSTRAINT [FK_ClientAuto]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clienti]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientAuto'
CREATE INDEX [IX_FK_ClientAuto]
ON [dbo].[Autoes]
    ([Client_Id]);
GO

-- Creating foreign key on [DetaliuComanda_Id] in table 'Comenzi'
ALTER TABLE [dbo].[Comenzi]
ADD CONSTRAINT [FK_ComandaDetaliuComanda]
    FOREIGN KEY ([DetaliuComanda_Id])
    REFERENCES [dbo].[DetaliuComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaDetaliuComanda'
CREATE INDEX [IX_FK_ComandaDetaliuComanda]
ON [dbo].[Comenzi]
    ([DetaliuComanda_Id]);
GO

-- Creating foreign key on [DetaliuComanda_Id] in table 'Mecanici'
ALTER TABLE [dbo].[Mecanici]
ADD CONSTRAINT [FK_DetaliuComandaMecanic]
    FOREIGN KEY ([DetaliuComanda_Id])
    REFERENCES [dbo].[DetaliuComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaMecanic'
CREATE INDEX [IX_FK_DetaliuComandaMecanic]
ON [dbo].[Mecanici]
    ([DetaliuComanda_Id]);
GO

-- Creating foreign key on [DetaliuComanda_Id] in table 'Operatii'
ALTER TABLE [dbo].[Operatii]
ADD CONSTRAINT [FK_DetaliuComandaOperatie]
    FOREIGN KEY ([DetaliuComanda_Id])
    REFERENCES [dbo].[DetaliuComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaOperatie'
CREATE INDEX [IX_FK_DetaliuComandaOperatie]
ON [dbo].[Operatii]
    ([DetaliuComanda_Id]);
GO

-- Creating foreign key on [DetaliuComanda_Id] in table 'Materiale'
ALTER TABLE [dbo].[Materiale]
ADD CONSTRAINT [FK_DetaliuComandaMaterial]
    FOREIGN KEY ([DetaliuComanda_Id])
    REFERENCES [dbo].[DetaliuComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaMaterial'
CREATE INDEX [IX_FK_DetaliuComandaMaterial]
ON [dbo].[Materiale]
    ([DetaliuComanda_Id]);
GO

-- Creating foreign key on [DetaliuComanda_Id] in table 'Imagini'
ALTER TABLE [dbo].[Imagini]
ADD CONSTRAINT [FK_DetaliuComandaImagine]
    FOREIGN KEY ([DetaliuComanda_Id])
    REFERENCES [dbo].[DetaliuComenzi]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaImagine'
CREATE INDEX [IX_FK_DetaliuComandaImagine]
ON [dbo].[Imagini]
    ([DetaliuComanda_Id]);
GO

-- Creating foreign key on [Sasiu_Id] in table 'Autoes'
ALTER TABLE [dbo].[Autoes]
ADD CONSTRAINT [FK_AutoSasiu]
    FOREIGN KEY ([Sasiu_Id])
    REFERENCES [dbo].[Sasius]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoSasiu'
CREATE INDEX [IX_FK_AutoSasiu]
ON [dbo].[Autoes]
    ([Sasiu_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------