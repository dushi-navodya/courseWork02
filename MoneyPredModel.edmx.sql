
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/22/2020 20:19:33
-- Generated from EDMX file: F:\MSC-Advanced Software Engineering\Enterprice Development\assignment2\Project\courseWork02\MoneyPredModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [test];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Appoinmen__Expen__4E88ABD4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appoinment] DROP CONSTRAINT [FK__Appoinmen__Expen__4E88ABD4];
GO
IF OBJECT_ID(N'[dbo].[FK__Appoinmen__Incom__4D94879B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appoinment] DROP CONSTRAINT [FK__Appoinmen__Incom__4D94879B];
GO
IF OBJECT_ID(N'[dbo].[FK__Expense__Categor__38996AB5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Expense] DROP CONSTRAINT [FK__Expense__Categor__38996AB5];
GO
IF OBJECT_ID(N'[dbo].[FK__Expense__UserID__37A5467C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Expense] DROP CONSTRAINT [FK__Expense__UserID__37A5467C];
GO
IF OBJECT_ID(N'[dbo].[FK__Income__UserID__33D4B598]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Income] DROP CONSTRAINT [FK__Income__UserID__33D4B598];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Appoinment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Appoinment];
GO
IF OBJECT_ID(N'[dbo].[Expense]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Expense];
GO
IF OBJECT_ID(N'[dbo].[ExpenseCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExpenseCategory];
GO
IF OBJECT_ID(N'[dbo].[Income]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Income];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Appoinments'
CREATE TABLE [dbo].[Appoinments] (
    [AppoinmentId] int  NOT NULL,
    [IncomeId] int  NULL,
    [ExpenseId] int  NULL,
    [InviteeName] varchar(255)  NULL,
    [Location] varchar(255)  NULL,
    [Purpose] varchar(255)  NULL
);
GO

-- Creating table 'Expenses'
CREATE TABLE [dbo].[Expenses] (
    [UserID] int  NOT NULL,
    [CategoryId] int  NOT NULL,
    [ExpensseId] int IDENTITY(1,1) NOT NULL,
    [Description] varchar(255)  NULL,
    [PayerName] varchar(255)  NULL,
    [Amount] decimal(8,4)  NULL,
    [Proffesion] varchar(255)  NULL,
    [Date] datetime  NULL,
    [IsRecurringEvent] tinyint  NULL,
    [IsBeginingMonth] tinyint  NULL,
    [IsEndMonth] tinyint  NULL,
    [IsSpecDate] tinyint  NULL,
    [SpecDate] datetime  NULL
);
GO

-- Creating table 'ExpenseCategories'
CREATE TABLE [dbo].[ExpenseCategories] (
    [CategoryId] int IDENTITY(1,1) NOT NULL,
    [CategoryName] varchar(255)  NULL,
    [CategoryType] varchar(255)  NULL,
    [CategoryOwner] varchar(255)  NULL,
    [Icon] varchar(255)  NULL
);
GO

-- Creating table 'Incomes'
CREATE TABLE [dbo].[Incomes] (
    [UserID] int  NOT NULL,
    [IncomeId] int IDENTITY(1,1) NOT NULL,
    [Description] varchar(255)  NULL,
    [PayerName] varchar(255)  NULL,
    [Amount] decimal(8,4)  NULL,
    [Proffesion] varchar(255)  NULL,
    [Date] datetime  NULL,
    [IsRecurringEvent] tinyint  NULL,
    [IsBeginingMonth] tinyint  NULL,
    [IsEndMonth] tinyint  NULL,
    [IsSpecDate] tinyint  NULL,
    [SpecDate] datetime  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(255)  NULL,
    [LastName] varchar(255)  NULL,
    [EMail] varchar(255)  NULL,
    [Proffesion] varchar(255)  NULL,
    [Password] nchar(10)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AppoinmentId] in table 'Appoinments'
ALTER TABLE [dbo].[Appoinments]
ADD CONSTRAINT [PK_Appoinments]
    PRIMARY KEY CLUSTERED ([AppoinmentId] ASC);
GO

-- Creating primary key on [ExpensseId] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [PK_Expenses]
    PRIMARY KEY CLUSTERED ([ExpensseId] ASC);
GO

-- Creating primary key on [CategoryId] in table 'ExpenseCategories'
ALTER TABLE [dbo].[ExpenseCategories]
ADD CONSTRAINT [PK_ExpenseCategories]
    PRIMARY KEY CLUSTERED ([CategoryId] ASC);
GO

-- Creating primary key on [IncomeId] in table 'Incomes'
ALTER TABLE [dbo].[Incomes]
ADD CONSTRAINT [PK_Incomes]
    PRIMARY KEY CLUSTERED ([IncomeId] ASC);
GO

-- Creating primary key on [UserID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ExpenseId] in table 'Appoinments'
ALTER TABLE [dbo].[Appoinments]
ADD CONSTRAINT [FK__Appoinmen__Expen__4E88ABD4]
    FOREIGN KEY ([ExpenseId])
    REFERENCES [dbo].[Expenses]
        ([ExpensseId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Appoinmen__Expen__4E88ABD4'
CREATE INDEX [IX_FK__Appoinmen__Expen__4E88ABD4]
ON [dbo].[Appoinments]
    ([ExpenseId]);
GO

-- Creating foreign key on [IncomeId] in table 'Appoinments'
ALTER TABLE [dbo].[Appoinments]
ADD CONSTRAINT [FK__Appoinmen__Incom__4D94879B]
    FOREIGN KEY ([IncomeId])
    REFERENCES [dbo].[Incomes]
        ([IncomeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Appoinmen__Incom__4D94879B'
CREATE INDEX [IX_FK__Appoinmen__Incom__4D94879B]
ON [dbo].[Appoinments]
    ([IncomeId]);
GO

-- Creating foreign key on [CategoryId] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [FK__Expense__Categor__38996AB5]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[ExpenseCategories]
        ([CategoryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Expense__Categor__38996AB5'
CREATE INDEX [IX_FK__Expense__Categor__38996AB5]
ON [dbo].[Expenses]
    ([CategoryId]);
GO

-- Creating foreign key on [UserID] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [FK__Expense__UserID__37A5467C]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[Users]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Expense__UserID__37A5467C'
CREATE INDEX [IX_FK__Expense__UserID__37A5467C]
ON [dbo].[Expenses]
    ([UserID]);
GO

-- Creating foreign key on [UserID] in table 'Incomes'
ALTER TABLE [dbo].[Incomes]
ADD CONSTRAINT [FK__Income__UserID__33D4B598]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[Users]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Income__UserID__33D4B598'
CREATE INDEX [IX_FK__Income__UserID__33D4B598]
ON [dbo].[Incomes]
    ([UserID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------