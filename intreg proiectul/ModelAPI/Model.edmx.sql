
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/02/2020 22:20:42
-- Generated from EDMX file: C:\Users\filos\source\repos\Proiect\ModelAPI\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [filo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MediaEvent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventSet] DROP CONSTRAINT [FK_MediaEvent];
GO
IF OBJECT_ID(N'[dbo].[FK_MediaPeople_Media]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MediaPeople] DROP CONSTRAINT [FK_MediaPeople_Media];
GO
IF OBJECT_ID(N'[dbo].[FK_MediaPeople_People]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MediaPeople] DROP CONSTRAINT [FK_MediaPeople_People];
GO
IF OBJECT_ID(N'[dbo].[FK_MediaPlace]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlaceSet] DROP CONSTRAINT [FK_MediaPlace];
GO
IF OBJECT_ID(N'[dbo].[FK_MediaTag]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TagSet] DROP CONSTRAINT [FK_MediaTag];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EventSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventSet];
GO
IF OBJECT_ID(N'[dbo].[MediaPeople]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MediaPeople];
GO
IF OBJECT_ID(N'[dbo].[MediaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MediaSet];
GO
IF OBJECT_ID(N'[dbo].[PeopleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PeopleSet];
GO
IF OBJECT_ID(N'[dbo].[PlaceSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlaceSet];
GO
IF OBJECT_ID(N'[dbo].[TagSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TagSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MediaSet'
CREATE TABLE [dbo].[MediaSet] (
    [MediaId] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [FullPath] nvarchar(max)  NOT NULL,
    [Format] nvarchar(max)  NOT NULL,
    [DateOfCreation] datetime  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'TagSet'
CREATE TABLE [dbo].[TagSet] (
    [TagId] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Media_MediaId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'EventSet'
CREATE TABLE [dbo].[EventSet] (
    [EventId] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Media_MediaId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PlaceSet'
CREATE TABLE [dbo].[PlaceSet] (
    [PlaceId] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Media_MediaId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PeopleSet'
CREATE TABLE [dbo].[PeopleSet] (
    [PeopleId] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MediaPeople'
CREATE TABLE [dbo].[MediaPeople] (
    [Media_MediaId] uniqueidentifier  NOT NULL,
    [People_PeopleId] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MediaId] in table 'MediaSet'
ALTER TABLE [dbo].[MediaSet]
ADD CONSTRAINT [PK_MediaSet]
    PRIMARY KEY CLUSTERED ([MediaId] ASC);
GO

-- Creating primary key on [TagId] in table 'TagSet'
ALTER TABLE [dbo].[TagSet]
ADD CONSTRAINT [PK_TagSet]
    PRIMARY KEY CLUSTERED ([TagId] ASC);
GO

-- Creating primary key on [EventId] in table 'EventSet'
ALTER TABLE [dbo].[EventSet]
ADD CONSTRAINT [PK_EventSet]
    PRIMARY KEY CLUSTERED ([EventId] ASC);
GO

-- Creating primary key on [PlaceId] in table 'PlaceSet'
ALTER TABLE [dbo].[PlaceSet]
ADD CONSTRAINT [PK_PlaceSet]
    PRIMARY KEY CLUSTERED ([PlaceId] ASC);
GO

-- Creating primary key on [PeopleId] in table 'PeopleSet'
ALTER TABLE [dbo].[PeopleSet]
ADD CONSTRAINT [PK_PeopleSet]
    PRIMARY KEY CLUSTERED ([PeopleId] ASC);
GO

-- Creating primary key on [Media_MediaId], [People_PeopleId] in table 'MediaPeople'
ALTER TABLE [dbo].[MediaPeople]
ADD CONSTRAINT [PK_MediaPeople]
    PRIMARY KEY CLUSTERED ([Media_MediaId], [People_PeopleId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Media_MediaId] in table 'MediaPeople'
ALTER TABLE [dbo].[MediaPeople]
ADD CONSTRAINT [FK_MediaPeople_Media]
    FOREIGN KEY ([Media_MediaId])
    REFERENCES [dbo].[MediaSet]
        ([MediaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [People_PeopleId] in table 'MediaPeople'
ALTER TABLE [dbo].[MediaPeople]
ADD CONSTRAINT [FK_MediaPeople_People]
    FOREIGN KEY ([People_PeopleId])
    REFERENCES [dbo].[PeopleSet]
        ([PeopleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaPeople_People'
CREATE INDEX [IX_FK_MediaPeople_People]
ON [dbo].[MediaPeople]
    ([People_PeopleId]);
GO

-- Creating foreign key on [Media_MediaId] in table 'PlaceSet'
ALTER TABLE [dbo].[PlaceSet]
ADD CONSTRAINT [FK_MediaPlace]
    FOREIGN KEY ([Media_MediaId])
    REFERENCES [dbo].[MediaSet]
        ([MediaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaPlace'
CREATE INDEX [IX_FK_MediaPlace]
ON [dbo].[PlaceSet]
    ([Media_MediaId]);
GO

-- Creating foreign key on [Media_MediaId] in table 'TagSet'
ALTER TABLE [dbo].[TagSet]
ADD CONSTRAINT [FK_MediaTag]
    FOREIGN KEY ([Media_MediaId])
    REFERENCES [dbo].[MediaSet]
        ([MediaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaTag'
CREATE INDEX [IX_FK_MediaTag]
ON [dbo].[TagSet]
    ([Media_MediaId]);
GO

-- Creating foreign key on [Media_MediaId] in table 'EventSet'
ALTER TABLE [dbo].[EventSet]
ADD CONSTRAINT [FK_MediaEvent]
    FOREIGN KEY ([Media_MediaId])
    REFERENCES [dbo].[MediaSet]
        ([MediaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaEvent'
CREATE INDEX [IX_FK_MediaEvent]
ON [dbo].[EventSet]
    ([Media_MediaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------