CREATE PROCEDURE [dbo].[Create]
@Email NVARCHAR(255),
@Password NVARCHAR(255)
AS
INSERT INTO Users
VALUES (@Email, @Password)