CREATE TABLE [dbo].[EventMembers]
(
	[EventId] INT NOT NULL, 
	[MemberId] INT NOT NULL, 
    CONSTRAINT [PK_EventMembers] PRIMARY KEY ([EventId], [MemberId]), 
    CONSTRAINT [FK_EventMembers_Events] FOREIGN KEY ([EventId]) REFERENCES [Events]([EventId]),
	CONSTRAINT [FK_EventMembers_Members] FOREIGN KEY ([MemberId]) REFERENCES [Members]([MemberId])  
)
