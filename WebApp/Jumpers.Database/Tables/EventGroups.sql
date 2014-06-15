CREATE TABLE [dbo].[EventGroups]
(
	[EventGroupId] INT NOT NULL  IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_EventGroups] PRIMARY KEY ([EventGroupId]) 
)
