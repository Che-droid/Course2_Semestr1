
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/25/2019 22:38:55
-- Generated from EDMX file: C:\Users\cathe\OneDrive\Документы\Visual Studio 2015\Projects\Test2\Test2\Test2DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Test2DB];
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

-- Creating table 'Questions'
CREATE TABLE [dbo].[Questions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [QuestionText] nvarchar(max)  NOT NULL,
    [Test_Id] int  NOT NULL
);
GO

-- Creating table 'Answers'
CREATE TABLE [dbo].[Answers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AnswerText] nvarchar(max)  NOT NULL,
    [IsCorrect] bit  NOT NULL,
    [Question_Id] int  NOT NULL
);
GO

-- Creating table 'Tests'
CREATE TABLE [dbo].[Tests] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [MinutesForTest] int  NOT NULL
);
GO

-- Creating table 'TestStatistics'
CREATE TABLE [dbo].[TestStatistics] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TimeInMinutes] int  NOT NULL,
    [NumberOfCorrect] int  NOT NULL,
    [PercentOfCorrect] decimal(18,0)  NOT NULL,
    [Test_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Questions'
ALTER TABLE [dbo].[Questions]
ADD CONSTRAINT [PK_Questions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Answers'
ALTER TABLE [dbo].[Answers]
ADD CONSTRAINT [PK_Answers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tests'
ALTER TABLE [dbo].[Tests]
ADD CONSTRAINT [PK_Tests]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TestStatistics'
ALTER TABLE [dbo].[TestStatistics]
ADD CONSTRAINT [PK_TestStatistics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Question_Id] in table 'Answers'
ALTER TABLE [dbo].[Answers]
ADD CONSTRAINT [FK_QuestionAnswer]
    FOREIGN KEY ([Question_Id])
    REFERENCES [dbo].[Questions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_QuestionAnswer'
CREATE INDEX [IX_FK_QuestionAnswer]
ON [dbo].[Answers]
    ([Question_Id]);
GO

-- Creating foreign key on [Test_Id] in table 'Questions'
ALTER TABLE [dbo].[Questions]
ADD CONSTRAINT [FK_TestQuestion]
    FOREIGN KEY ([Test_Id])
    REFERENCES [dbo].[Tests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TestQuestion'
CREATE INDEX [IX_FK_TestQuestion]
ON [dbo].[Questions]
    ([Test_Id]);
GO

-- Creating foreign key on [Test_Id] in table 'TestStatistics'
ALTER TABLE [dbo].[TestStatistics]
ADD CONSTRAINT [FK_TestTestStatistic]
    FOREIGN KEY ([Test_Id])
    REFERENCES [dbo].[Tests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TestTestStatistic'
CREATE INDEX [IX_FK_TestTestStatistic]
ON [dbo].[TestStatistics]
    ([Test_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------