﻿CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] NVARCHAR(255) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL,
)