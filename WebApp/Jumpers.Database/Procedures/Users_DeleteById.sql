CREATE PROCEDURE [dbo].[Users_DeleteById]
	@userId INT
AS
BEGIN
	DELETE FROM [dbo].Users
	WHERE UserId = @userId
END