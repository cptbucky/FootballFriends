CREATE PROCEDURE [dbo].[EventGroups_Insert]
	@name NVARCHAR(50)
AS
BEGIN
	INSERT INTO [dbo].EventGroups(Name)
	VALUES (@name)

	DECLARE @newId INT
	SET @newId = SCOPE_IDENTITY()

	SELECT EventGroupId, Name
	FROM [dbo].EventGroups
	WHERE EventGroupId = @newId
END