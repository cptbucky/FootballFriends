CREATE PROCEDURE [dbo].[Events_Update]
	@eventId INT,
	@eventGroupId INT = NULL,
	@start DATETIME,
	@finish DATETIME
AS
BEGIN
	UPDATE [dbo].Events WITH (ROWLOCK)
	SET EventGroupId = @eventGroupId,
		Start = @start,
		Finish = @finish
	WHERE EventId = @eventId
END