
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/01/2017 17:51:55
-- Generated from EDMX file: D:\rybchenko\myProjects\congratulation\congratulation\congratulation\Models\congaratulationModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [userCongratulation];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_uc_Useruc_CongratulationCard]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[uc_CongratulationCardSet] DROP CONSTRAINT [FK_uc_Useruc_CongratulationCard];
GO
IF OBJECT_ID(N'[dbo].[FK_uc_CongratulationCarduc_Congratulation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[uc_CongratulationSet] DROP CONSTRAINT [FK_uc_CongratulationCarduc_Congratulation];
GO
IF OBJECT_ID(N'[dbo].[FK_uc_CongratulationCarduc_Gift_uc_CongratulationCard]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[uc_CongratulationCarduc_Gift] DROP CONSTRAINT [FK_uc_CongratulationCarduc_Gift_uc_CongratulationCard];
GO
IF OBJECT_ID(N'[dbo].[FK_uc_CongratulationCarduc_Gift_uc_Gift]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[uc_CongratulationCarduc_Gift] DROP CONSTRAINT [FK_uc_CongratulationCarduc_Gift_uc_Gift];
GO
IF OBJECT_ID(N'[dbo].[FK_uc_CongratulationCarduc_Photo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[uc_PhotoSet] DROP CONSTRAINT [FK_uc_CongratulationCarduc_Photo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[uc_UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[uc_UserSet];
GO
IF OBJECT_ID(N'[dbo].[uc_CongratulationCardSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[uc_CongratulationCardSet];
GO
IF OBJECT_ID(N'[dbo].[uc_CongratulationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[uc_CongratulationSet];
GO
IF OBJECT_ID(N'[dbo].[uc_GiftSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[uc_GiftSet];
GO
IF OBJECT_ID(N'[dbo].[uc_PhotoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[uc_PhotoSet];
GO
IF OBJECT_ID(N'[dbo].[uc_CongratulationCarduc_Gift]', 'U') IS NOT NULL
    DROP TABLE [dbo].[uc_CongratulationCarduc_Gift];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'uc_UserSet'
CREATE TABLE [dbo].[uc_UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Alias] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NULL,
    [BirthdayDate] datetime  NOT NULL
);
GO

-- Creating table 'uc_CongratulationCardSet'
CREATE TABLE [dbo].[uc_CongratulationCardSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [HeaderText] nvarchar(max)  NOT NULL,
    [HeaderBackgroundImage] nvarchar(max)  NOT NULL,
    [Whom] nvarchar(max)  NOT NULL,
    [HeaderImageUrl] nvarchar(max)  NOT NULL,
    [uc_User_Id] int  NOT NULL
);
GO

-- Creating table 'uc_CongratulationSet'
CREATE TABLE [dbo].[uc_CongratulationSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CongratulationImageUrl] nvarchar(max)  NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Who] nvarchar(max)  NOT NULL,
    [uc_CongratulationCard_Id] int  NOT NULL
);
GO

-- Creating table 'uc_GiftSet'
CREATE TABLE [dbo].[uc_GiftSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GiftImage] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'uc_PhotoSet'
CREATE TABLE [dbo].[uc_PhotoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PhotoUrl] nvarchar(max)  NOT NULL,
    [uc_CongratulationCard_Id] int  NOT NULL
);
GO

-- Creating table 'uc_CongratulationCarduc_Gift'
CREATE TABLE [dbo].[uc_CongratulationCarduc_Gift] (
    [uc_CongratulationCard_Id] int  NOT NULL,
    [uc_Gift_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'uc_UserSet'
ALTER TABLE [dbo].[uc_UserSet]
ADD CONSTRAINT [PK_uc_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'uc_CongratulationCardSet'
ALTER TABLE [dbo].[uc_CongratulationCardSet]
ADD CONSTRAINT [PK_uc_CongratulationCardSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'uc_CongratulationSet'
ALTER TABLE [dbo].[uc_CongratulationSet]
ADD CONSTRAINT [PK_uc_CongratulationSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'uc_GiftSet'
ALTER TABLE [dbo].[uc_GiftSet]
ADD CONSTRAINT [PK_uc_GiftSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'uc_PhotoSet'
ALTER TABLE [dbo].[uc_PhotoSet]
ADD CONSTRAINT [PK_uc_PhotoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [uc_CongratulationCard_Id], [uc_Gift_Id] in table 'uc_CongratulationCarduc_Gift'
ALTER TABLE [dbo].[uc_CongratulationCarduc_Gift]
ADD CONSTRAINT [PK_uc_CongratulationCarduc_Gift]
    PRIMARY KEY CLUSTERED ([uc_CongratulationCard_Id], [uc_Gift_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [uc_User_Id] in table 'uc_CongratulationCardSet'
ALTER TABLE [dbo].[uc_CongratulationCardSet]
ADD CONSTRAINT [FK_uc_Useruc_CongratulationCard]
    FOREIGN KEY ([uc_User_Id])
    REFERENCES [dbo].[uc_UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_uc_Useruc_CongratulationCard'
CREATE INDEX [IX_FK_uc_Useruc_CongratulationCard]
ON [dbo].[uc_CongratulationCardSet]
    ([uc_User_Id]);
GO

-- Creating foreign key on [uc_CongratulationCard_Id] in table 'uc_CongratulationSet'
ALTER TABLE [dbo].[uc_CongratulationSet]
ADD CONSTRAINT [FK_uc_CongratulationCarduc_Congratulation]
    FOREIGN KEY ([uc_CongratulationCard_Id])
    REFERENCES [dbo].[uc_CongratulationCardSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_uc_CongratulationCarduc_Congratulation'
CREATE INDEX [IX_FK_uc_CongratulationCarduc_Congratulation]
ON [dbo].[uc_CongratulationSet]
    ([uc_CongratulationCard_Id]);
GO

-- Creating foreign key on [uc_CongratulationCard_Id] in table 'uc_CongratulationCarduc_Gift'
ALTER TABLE [dbo].[uc_CongratulationCarduc_Gift]
ADD CONSTRAINT [FK_uc_CongratulationCarduc_Gift_uc_CongratulationCard]
    FOREIGN KEY ([uc_CongratulationCard_Id])
    REFERENCES [dbo].[uc_CongratulationCardSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [uc_Gift_Id] in table 'uc_CongratulationCarduc_Gift'
ALTER TABLE [dbo].[uc_CongratulationCarduc_Gift]
ADD CONSTRAINT [FK_uc_CongratulationCarduc_Gift_uc_Gift]
    FOREIGN KEY ([uc_Gift_Id])
    REFERENCES [dbo].[uc_GiftSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_uc_CongratulationCarduc_Gift_uc_Gift'
CREATE INDEX [IX_FK_uc_CongratulationCarduc_Gift_uc_Gift]
ON [dbo].[uc_CongratulationCarduc_Gift]
    ([uc_Gift_Id]);
GO

-- Creating foreign key on [uc_CongratulationCard_Id] in table 'uc_PhotoSet'
ALTER TABLE [dbo].[uc_PhotoSet]
ADD CONSTRAINT [FK_uc_CongratulationCarduc_Photo]
    FOREIGN KEY ([uc_CongratulationCard_Id])
    REFERENCES [dbo].[uc_CongratulationCardSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_uc_CongratulationCarduc_Photo'
CREATE INDEX [IX_FK_uc_CongratulationCarduc_Photo]
ON [dbo].[uc_PhotoSet]
    ([uc_CongratulationCard_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------