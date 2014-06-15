CREATE TABLE [dbo].[UserEvents]
(
	[UserId] INT NOT NULL, 
	[EventId] INT NOT NULL, 
    CONSTRAINT [PK_UserEvents] PRIMARY KEY ([UserId], [EventId]), 
    CONSTRAINT [FK_UserEvents_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId]), 
    CONSTRAINT [FK_UserEvents_Events] FOREIGN KEY ([EventId]) REFERENCES [Events]([EventId])  
)
