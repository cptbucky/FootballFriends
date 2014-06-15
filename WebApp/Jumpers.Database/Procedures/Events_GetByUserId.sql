CREATE PROCEDURE [dbo].[Events_GetByUserId]
	@userId int
AS
	SELECT e.EventId
	FROM [dbo].UserEvents ue INNER JOIN [dbo].Events e ON ue.EventId = e.EventId
	WHERE ue.UserId = @userId
RETURN 0
