CREATE PROCEDURE [dbo].[Members_Update]
	@memberId INT,
	@name NVARCHAR(50)
AS
BEGIN
	UPDATE [dbo].Members WITH (ROWLOCK)
	SET Name = @name
	WHERE MemberId = @memberId
END