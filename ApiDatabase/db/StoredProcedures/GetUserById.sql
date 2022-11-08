CREATE PROCEDURE [dbo].[GetUserById]
@id int
AS
SELECT * FROM Users
WHERE id=@id
