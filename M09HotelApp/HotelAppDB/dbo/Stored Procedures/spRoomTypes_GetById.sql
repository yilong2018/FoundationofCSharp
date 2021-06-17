CREATE PROCEDURE [dbo].[spRoomTypes_GetById]
	@id int
AS
begin
	set nocount on;
	select [Id], [Title], [Description], [Price]
	from RoomTypes
	where Id=@id
end
