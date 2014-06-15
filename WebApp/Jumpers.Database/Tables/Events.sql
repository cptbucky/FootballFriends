CREATE TABLE [dbo].[Events]
(
	[EventId] INT NOT NULL  IDENTITY, 
	[EventGroupId] INT NULL, 
    [Start] DATETIME NOT NULL, 
    [Finish] DATETIME NOT NULL, 
    CONSTRAINT [PK_Events] PRIMARY KEY ([EventId]), 
    CONSTRAINT [FK_Events_EventGroups] FOREIGN KEY ([EventGroupId]) REFERENCES [EventGroups]([EventGroupId]) 
)
