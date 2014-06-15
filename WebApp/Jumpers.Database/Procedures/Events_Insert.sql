CREATE PROCEDURE [dbo].[Events_Insert]
	@start DATETIME,
	@finish DATETIME
AS
BEGIN
	INSERT INTO [dbo].Events (Start, Finish)
	VALUES (@start, @finish)

	DECLARE @newId INT
	SET @newId = SCOPE_IDENTITY()

	SELECT EventId, Start, Finish
	FROM [dbo].Events
	WHERE EventId = @newId
END