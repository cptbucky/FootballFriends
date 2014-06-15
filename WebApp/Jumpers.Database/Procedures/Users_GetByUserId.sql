CREATE PROCEDURE [dbo].[Users_GetByUserId]
	@userId int
AS
	SELECT UserId
	FROM [dbo].Users
	WHERE UserId = @userId
RETURN 0
