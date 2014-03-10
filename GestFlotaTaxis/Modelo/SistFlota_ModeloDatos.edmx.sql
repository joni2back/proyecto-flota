
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 03/10/2014 02:14:17
-- Generated from EDMX file: C:\Users\Admin\Documents\GitHub\proyecto-flota\GestFlotaTaxis\Modelo\SistFlota_ModeloDatos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;

USE [SistFlota_db];

IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TipodeGastoGasto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Gastos] DROP CONSTRAINT [FK_TipodeGastoGasto];

IF OBJECT_ID(N'[dbo].[FK_VehiculoGasto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Gastos] DROP CONSTRAINT [FK_VehiculoGasto];

IF OBJECT_ID(N'[dbo].[FK_EmpresaCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clientes] DROP CONSTRAINT [FK_EmpresaCliente];


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TiposdeGasto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TiposdeGasto];

IF OBJECT_ID(N'[dbo].[Gastos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Gastos];

IF OBJECT_ID(N'[dbo].[Vehiculos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehiculos];

IF OBJECT_ID(N'[dbo].[Choferes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Choferes];

IF OBJECT_ID(N'[dbo].[Empresas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empresas];

IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];

IF OBJECT_ID(N'[dbo].[Turnos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Turnos];


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TiposdeGasto'
CREATE TABLE [dbo].[TiposdeGasto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);


-- Creating table 'Gastos'
CREATE TABLE [dbo].[Gastos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Monto] decimal(18,0)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [FechaVencimiento] datetime  NOT NULL,
    [HoraEmision] datetime  NULL,
    [FechaEmision] datetime  NULL,
    [Usuario] nvarchar(50)  NOT NULL,
    [FechayHora] datetime  NOT NULL,
    [Operacion] nvarchar(max)  NOT NULL,
    [TipodeGasto_Id] int  NOT NULL,
    [Vehiculo_Patente] nvarchar(7)  NOT NULL
);


-- Creating table 'Vehiculos'
CREATE TABLE [dbo].[Vehiculos] (
    [Patente] nvarchar(7)  NOT NULL,
    [PatenteTaxi] int  NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Año] int  NOT NULL,
    [Color] nvarchar(max)  NOT NULL,
    [Kilometraje] int  NOT NULL
);


-- Creating table 'Choferes'
CREATE TABLE [dbo].[Choferes] (
    [Documento] int  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Licencia] nvarchar(max)  NOT NULL,
    [Domicilio] nvarchar(max)  NOT NULL,
    [Localidad] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NULL,
    [FechaNacimiento] datetime  NOT NULL,
    [Correo] nvarchar(max)  NULL,
    [Foto] varbinary(max)  NULL
);


-- Creating table 'Empresas'
CREATE TABLE [dbo].[Empresas] (
    [Cuit] int  NOT NULL,
    [RazonSocial] nvarchar(max)  NOT NULL,
    [Domicilio] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Localidad] nvarchar(max)  NOT NULL,
    [Correo] nvarchar(max)  NOT NULL
);


-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Documento] int  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [FechaNacimiento] datetime  NOT NULL,
    [Domicilio] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Correo] nvarchar(max)  NOT NULL,
    [EmpresaCUIL] int  NOT NULL
);


-- Creating table 'Turnos'
CREATE TABLE [dbo].[Turnos] (
    [Id] int IDENTITY(1,1) NOT NULL
);


-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TiposdeGasto'
ALTER TABLE [dbo].[TiposdeGasto]
ADD CONSTRAINT [PK_TiposdeGasto]
    PRIMARY KEY CLUSTERED ([Id] ASC);


-- Creating primary key on [Id] in table 'Gastos'
ALTER TABLE [dbo].[Gastos]
ADD CONSTRAINT [PK_Gastos]
    PRIMARY KEY CLUSTERED ([Id] ASC);


-- Creating primary key on [Patente] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [PK_Vehiculos]
    PRIMARY KEY CLUSTERED ([Patente] ASC);


-- Creating primary key on [Documento] in table 'Choferes'
ALTER TABLE [dbo].[Choferes]
ADD CONSTRAINT [PK_Choferes]
    PRIMARY KEY CLUSTERED ([Documento] ASC);


-- Creating primary key on [Cuit] in table 'Empresas'
ALTER TABLE [dbo].[Empresas]
ADD CONSTRAINT [PK_Empresas]
    PRIMARY KEY CLUSTERED ([Cuit] ASC);


-- Creating primary key on [Documento] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Documento] ASC);


-- Creating primary key on [Id] in table 'Turnos'
ALTER TABLE [dbo].[Turnos]
ADD CONSTRAINT [PK_Turnos]
    PRIMARY KEY CLUSTERED ([Id] ASC);


-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TipodeGasto_Id] in table 'Gastos'
ALTER TABLE [dbo].[Gastos]
ADD CONSTRAINT [FK_TipodeGastoGasto]
    FOREIGN KEY ([TipodeGasto_Id])
    REFERENCES [dbo].[TiposdeGasto]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TipodeGastoGasto'
CREATE INDEX [IX_FK_TipodeGastoGasto]
ON [dbo].[Gastos]
    ([TipodeGasto_Id]);


-- Creating foreign key on [Vehiculo_Patente] in table 'Gastos'
ALTER TABLE [dbo].[Gastos]
ADD CONSTRAINT [FK_VehiculoGasto]
    FOREIGN KEY ([Vehiculo_Patente])
    REFERENCES [dbo].[Vehiculos]
        ([Patente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VehiculoGasto'
CREATE INDEX [IX_FK_VehiculoGasto]
ON [dbo].[Gastos]
    ([Vehiculo_Patente]);


-- Creating foreign key on [EmpresaCUIL] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [FK_EmpresaCliente]
    FOREIGN KEY ([EmpresaCUIL])
    REFERENCES [dbo].[Empresas]
        ([Cuit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpresaCliente'
CREATE INDEX [IX_FK_EmpresaCliente]
ON [dbo].[Clientes]
    ([EmpresaCUIL]);


-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------