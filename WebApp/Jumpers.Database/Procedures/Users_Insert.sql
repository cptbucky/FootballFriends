CREATE PROCEDURE [dbo].[Users_Insert]
	@email NVARCHAR(50)
AS
BEGIN
	INSERT INTO [dbo].Users (Email)
	VALUES (@email)

	DECLARE @newId INT
	SET @newId = SCOPE_IDENTITY()

	SELECT UserId, Email
	FROM [dbo].Users
	WHERE UserId = @newId
END