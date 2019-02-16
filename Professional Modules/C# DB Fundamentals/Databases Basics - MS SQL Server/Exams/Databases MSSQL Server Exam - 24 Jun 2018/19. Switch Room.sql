GO
CREATE PROCEDURE usp_SwitchRoom(@TripId INT, @TargetRoomId INT)
AS
BEGIN
 
DECLARE @HotelId INT = (SELECT TOP(1) r.HotelId
                               FROM Trips AS t
                               JOIN Rooms AS r
                               ON r.Id = t.RoomId
                               WHERE t.Id = @TripId)
     
     DECLARE @TargetRoomHotelId INT = (SELECT TOP(1) r.HotelId
                                        FROM Rooms AS r
                                        WHERE r.Id = @TargetRoomId)
 
IF(@HotelId != @TargetRoomHotelId)
BEGIN
RAISERROR('Target room is in another hotel!', 16, 1)
    RETURN
END
 
  DECLARE @NumberOfPeople INT = (SELECT COUNT(*)
                                      FROM AccountsTrips AS at
                                      WHERE at.TripId = @TripId)
 
    IF((SELECT TOP(1) r.Beds FROM Rooms AS r WHERE r.Id = @TargetRoomId) < @NumberOfPeople)
    BEGIN
     RAISERROR('Not enough beds in target room!', 16, 1)
    RETURN
    END
 
UPDATE Trips
SET RoomId = @TargetRoomId
WHERE Id = @TripId
 
END
 
EXEC usp_SwitchRoom 10, 11
SELECT RoomId FROM Trips WHERE Id = 10
 
EXEC usp_SwitchRoom 10, 7
EXEC usp_SwitchRoom 10, 8