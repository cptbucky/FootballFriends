CREATE PROCEDURE [dbo].[Users_Update]
	@userId INT,
	@email NVARCHAR(50)
AS
BEGIN
	UPDATE [dbo].Users WITH (ROWLOCK)
	SET Email = @email
	WHERE UserId = @userId
END