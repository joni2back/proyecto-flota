
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 02/19/2013 18:49:55
-- Generated from EDMX file: G:\FACU\FINAL TDC 2013\GestFlotaTaxis 19-02-13 0131 FINAL 1\GestFlotaTaxis\Modelo\SEGURIDAD\SistFlota_Seguridad_Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;

USE [SistFlota_Seguridad];

IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PermisoPerfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Perfiles] DROP CONSTRAINT [FK_PermisoPerfil];

IF OBJECT_ID(N'[dbo].[FK_FormularioPerfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Perfiles] DROP CONSTRAINT [FK_FormularioPerfil];

IF OBJECT_ID(N'[dbo].[FK_GrupoPerfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Perfiles] DROP CONSTRAINT [FK_GrupoPerfil];

IF OBJECT_ID(N'[dbo].[FK_UsuarioGrupo_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuarioGrupo] DROP CONSTRAINT [FK_UsuarioGrupo_Usuario];

IF OBJECT_ID(N'[dbo].[FK_UsuarioGrupo_Grupo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuarioGrupo] DROP CONSTRAINT [FK_UsuarioGrupo_Grupo];


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];

IF OBJECT_ID(N'[dbo].[Grupos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Grupos];

IF OBJECT_ID(N'[dbo].[Perfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Perfiles];

IF OBJECT_ID(N'[dbo].[Permisos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Permisos];

IF OBJECT_ID(N'[dbo].[Formularios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Formularios];

IF OBJECT_ID(N'[dbo].[UsuarioGrupo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuarioGrupo];


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [IDusuario] nvarchar(50)  NOT NULL,
    [NombreApellido] nvarchar(max)  NOT NULL,
    [Contraseña] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Habilitado] bit  NOT NULL,
    [Activo] bit  NOT NULL,
    [PrimerVez] bit  NOT NULL
);


-- Creating table 'Grupos'
CREATE TABLE [dbo].[Grupos] (
    [IDgrupo] nvarchar(50)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);


-- Creating table 'Perfiles'
CREATE TABLE [dbo].[Perfiles] (
    [IDperfil] int IDENTITY(1,1) NOT NULL,
    [Permiso_IDpermiso] nvarchar(50)  NOT NULL,
    [Formulario_IDformulario] nvarchar(50)  NOT NULL,
    [Grupo_IDgrupo] nvarchar(50)  NOT NULL
);


-- Creating table 'Permisos'
CREATE TABLE [dbo].[Permisos] (
    [IDpermiso] nvarchar(50)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);


-- Creating table 'Formularios'
CREATE TABLE [dbo].[Formularios] (
    [IDformulario] nvarchar(50)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);


-- Creating table 'UsuarioGrupo'
CREATE TABLE [dbo].[UsuarioGrupo] (
    [Usuario_IDusuario] nvarchar(50)  NOT NULL,
    [Grupo_IDgrupo] nvarchar(50)  NOT NULL
);


-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IDusuario] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([IDusuario] ASC);


-- Creating primary key on [IDgrupo] in table 'Grupos'
ALTER TABLE [dbo].[Grupos]
ADD CONSTRAINT [PK_Grupos]
    PRIMARY KEY CLUSTERED ([IDgrupo] ASC);


-- Creating primary key on [IDperfil] in table 'Perfiles'
ALTER TABLE [dbo].[Perfiles]
ADD CONSTRAINT [PK_Perfiles]
    PRIMARY KEY CLUSTERED ([IDperfil] ASC);


-- Creating primary key on [IDpermiso] in table 'Permisos'
ALTER TABLE [dbo].[Permisos]
ADD CONSTRAINT [PK_Permisos]
    PRIMARY KEY CLUSTERED ([IDpermiso] ASC);


-- Creating primary key on [IDformulario] in table 'Formularios'
ALTER TABLE [dbo].[Formularios]
ADD CONSTRAINT [PK_Formularios]
    PRIMARY KEY CLUSTERED ([IDformulario] ASC);


-- Creating primary key on [Usuario_IDusuario], [Grupo_IDgrupo] in table 'UsuarioGrupo'
ALTER TABLE [dbo].[UsuarioGrupo]
ADD CONSTRAINT [PK_UsuarioGrupo]
    PRIMARY KEY NONCLUSTERED ([Usuario_IDusuario], [Grupo_IDgrupo] ASC);


-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Permiso_IDpermiso] in table 'Perfiles'
ALTER TABLE [dbo].[Perfiles]
ADD CONSTRAINT [FK_PermisoPerfil]
    FOREIGN KEY ([Permiso_IDpermiso])
    REFERENCES [dbo].[Permisos]
        ([IDpermiso])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PermisoPerfil'
CREATE INDEX [IX_FK_PermisoPerfil]
ON [dbo].[Perfiles]
    ([Permiso_IDpermiso]);


-- Creating foreign key on [Formulario_IDformulario] in table 'Perfiles'
ALTER TABLE [dbo].[Perfiles]
ADD CONSTRAINT [FK_FormularioPerfil]
    FOREIGN KEY ([Formulario_IDformulario])
    REFERENCES [dbo].[Formularios]
        ([IDformulario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FormularioPerfil'
CREATE INDEX [IX_FK_FormularioPerfil]
ON [dbo].[Perfiles]
    ([Formulario_IDformulario]);


-- Creating foreign key on [Grupo_IDgrupo] in table 'Perfiles'
ALTER TABLE [dbo].[Perfiles]
ADD CONSTRAINT [FK_GrupoPerfil]
    FOREIGN KEY ([Grupo_IDgrupo])
    REFERENCES [dbo].[Grupos]
        ([IDgrupo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GrupoPerfil'
CREATE INDEX [IX_FK_GrupoPerfil]
ON [dbo].[Perfiles]
    ([Grupo_IDgrupo]);


-- Creating foreign key on [Usuario_IDusuario] in table 'UsuarioGrupo'
ALTER TABLE [dbo].[UsuarioGrupo]
ADD CONSTRAINT [FK_UsuarioGrupo_Usuario]
    FOREIGN KEY ([Usuario_IDusuario])
    REFERENCES [dbo].[Usuarios]
        ([IDusuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating foreign key on [Grupo_IDgrupo] in table 'UsuarioGrupo'
ALTER TABLE [dbo].[UsuarioGrupo]
ADD CONSTRAINT [FK_UsuarioGrupo_Grupo]
    FOREIGN KEY ([Grupo_IDgrupo])
    REFERENCES [dbo].[Grupos]
        ([IDgrupo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioGrupo_Grupo'
CREATE INDEX [IX_FK_UsuarioGrupo_Grupo]
ON [dbo].[UsuarioGrupo]
    ([Grupo_IDgrupo]);


-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------