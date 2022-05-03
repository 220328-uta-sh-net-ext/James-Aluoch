CREATE TABLE [dbo].[masterPass]
(
	[passwordId] INT NOT NULL PRIMARY KEY,
	[pass] VARCHAR (100) NOT NULL,
	PRIMARY KEY CLUSTERED [passwordId] ASC
);
