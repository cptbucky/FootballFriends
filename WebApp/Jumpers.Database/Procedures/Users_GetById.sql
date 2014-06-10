CREATE PROCEDURE [dbo].[Users_GetById]
	@id int
AS
	SELECT Id, Email
	FROM [dbo].Users
	WHERE Id = @id
RETURN 0
