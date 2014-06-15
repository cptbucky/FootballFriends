CREATE TABLE [dbo].[Members]
(
	[MemberId] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Members] PRIMARY KEY ([MemberId])  
)
