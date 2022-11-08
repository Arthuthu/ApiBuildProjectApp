CREATE PROCEDURE [dbo].[Delete]
@id int
AS
DELETE FROM Users
WHERE @id=id
