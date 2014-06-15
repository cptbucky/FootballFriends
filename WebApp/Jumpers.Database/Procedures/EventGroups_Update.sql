CREATE PROCEDURE [dbo].[EventGroups_Update]
	@eventGroupId INT,
	@name NVARCHAR(50)
AS
BEGIN
	UPDATE [dbo].EventGroups WITH (ROWLOCK)
	SET Name = @name
	WHERE EventGroupId = @eventGroupId
END