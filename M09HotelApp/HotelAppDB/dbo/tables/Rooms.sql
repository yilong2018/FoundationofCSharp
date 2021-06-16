﻿CREATE TABLE [dbo].[Rooms]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RoomNumber] VARCHAR(10) NOT NULL, 
    [RoomTypeId] INT NOT NULL, 
    CONSTRAINT [FK_Rooms_ToRoomTypes] FOREIGN KEY (RoomTypeId) REFERENCES RoomTypes(Id)
)
