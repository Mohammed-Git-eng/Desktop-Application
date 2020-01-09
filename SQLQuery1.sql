CREATE TABLE [name].[Table]
(
	[Customer Number] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [Surname] NVARCHAR(100) NULL, 
    [Country] NVARCHAR(100) NULL, 
    [Hotel Name] NVARCHAR(100) NULL, 
    [Price] NVARCHAR(100) NULL, 
    [Start Date] DATE NULL, 
    [end Date] DATETIME NULL, 
    [Married Status] BIT NULL
)
