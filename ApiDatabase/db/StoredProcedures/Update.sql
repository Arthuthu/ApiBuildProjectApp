CREATE PROCEDURE [dbo].[Update]
@Email NVARCHAR(255),
@Password NVARCHAR(255)
AS
UPDATE Users
SET Email = @Email, Password = @Password

