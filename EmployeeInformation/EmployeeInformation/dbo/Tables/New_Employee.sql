CREATE TABLE [dbo].[New_Employee]
(
	[Id] INT             IDENTITY (1, 1) NOT NULL,
	[FirstName] NVARCHAR (50)   NULL,
    [LastName]  NVARCHAR (50)   NULL,
	[Age] int NULL,
	[Length]  NUMERIC (4, 2) NULL
	CONSTRAINT [PK_NewEmployeeEntityID] PRIMARY KEY CLUSTERED ([Id] ASC)
)
