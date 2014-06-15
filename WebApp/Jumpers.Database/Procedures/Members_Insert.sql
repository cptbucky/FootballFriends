CREATE PROCEDURE [dbo].[Members_Insert]
	@name NVARCHAR(50)
AS
BEGIN
	INSERT INTO [dbo].Members(Name)
	VALUES (@name)

	DECLARE @newId INT
	SET @newId = SCOPE_IDENTITY()

	SELECT MemberId, Name
	FROM [dbo].Members
	WHERE MemberId = @newId
END