CREATE PROCEDURE [dbo].[Members_GetByEventId]
	@eventId int
AS
	SELECT m.MemberId
	FROM [dbo].EventMembers em INNER JOIN [dbo].Members m ON em.MemberId = m.MemberId
	WHERE em.EventId = @eventId
RETURN 0
