
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 03/03/2014 15:30:38
-- Generated from EDMX file: C:\Users\Adelquis\Documents\GitHub\proyecto-flota\GestFlotaTaxis\Modelo\SistFlota_ModeloDatos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SistFlota_db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TipodeGastoGasto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Gastos] DROP CONSTRAINT [FK_TipodeGastoGasto];
GO
IF OBJECT_ID(N'[dbo].[FK_VehiculoGasto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Gastos] DROP CONSTRAINT [FK_VehiculoGasto];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpresaCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cliente] DROP CONSTRAINT [FK_EmpresaCliente];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TiposdeGasto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TiposdeGasto];
GO
IF OBJECT_ID(N'[dbo].[Gastos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Gastos];
GO
IF OBJECT_ID(N'[dbo].[Vehiculos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehiculos];
GO
IF OBJECT_ID(N'[dbo].[Choferes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Choferes];
GO
IF OBJECT_ID(N'[dbo].[Empresa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empresa];
GO
IF OBJECT_ID(N'[dbo].[Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cliente];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TiposdeGasto'
CREATE TABLE [dbo].[TiposdeGasto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

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
GO

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
GO

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
    [Foto] nvarchar(max)  NULL
);
GO

-- Creating table 'Empresa'
CREATE TABLE [dbo].[Empresa] (
    [CUIL] int IDENTITY(1,1) NOT NULL,
    [RazonSocial] nvarchar(max)  NOT NULL,
    [Domicilio] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Localidad] nvarchar(max)  NOT NULL,
    [Correo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Cliente'
CREATE TABLE [dbo].[Cliente] (
    [Documento] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Domicilio] nvarchar(max)  NOT NULL,
    [FechaNacimiento] datetime  NOT NULL,
    [Localidad] nvarchar(max)  NOT NULL,
    [Correo] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [EmpresaCUIL] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TiposdeGasto'
ALTER TABLE [dbo].[TiposdeGasto]
ADD CONSTRAINT [PK_TiposdeGasto]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Gastos'
ALTER TABLE [dbo].[Gastos]
ADD CONSTRAINT [PK_Gastos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Patente] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [PK_Vehiculos]
    PRIMARY KEY CLUSTERED ([Patente] ASC);
GO

-- Creating primary key on [Documento] in table 'Choferes'
ALTER TABLE [dbo].[Choferes]
ADD CONSTRAINT [PK_Choferes]
    PRIMARY KEY CLUSTERED ([Documento] ASC);
GO

-- Creating primary key on [CUIL] in table 'Empresa'
ALTER TABLE [dbo].[Empresa]
ADD CONSTRAINT [PK_Empresa]
    PRIMARY KEY CLUSTERED ([CUIL] ASC);
GO

-- Creating primary key on [Documento] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [PK_Cliente]
    PRIMARY KEY CLUSTERED ([Documento] ASC);
GO

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
GO

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
GO

-- Creating foreign key on [EmpresaCUIL] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [FK_EmpresaCliente]
    FOREIGN KEY ([EmpresaCUIL])
    REFERENCES [dbo].[Empresa]
        ([CUIL])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpresaCliente'
CREATE INDEX [IX_FK_EmpresaCliente]
ON [dbo].[Cliente]
    ([EmpresaCUIL]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------