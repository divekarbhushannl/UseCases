CREATE TABLE [dbo].[Employee] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (50)   NULL,
    [LastName]  NVARCHAR (50)   NULL,
    [Age]       INT             NULL,
    [Salary]    NUMERIC (18, 2) NULL,
    CONSTRAINT [PK_EmployeeEntityID] PRIMARY KEY CLUSTERED ([Id] ASC)
);

