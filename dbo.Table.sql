CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Description] NCHAR(100) NOT NULL, 
    [Number] INT NOT NULL, 
    [Price] DECIMAL(6, 2) NOT NULL, 
    [Archieved ] NCHAR(100) NOT NULL
)
