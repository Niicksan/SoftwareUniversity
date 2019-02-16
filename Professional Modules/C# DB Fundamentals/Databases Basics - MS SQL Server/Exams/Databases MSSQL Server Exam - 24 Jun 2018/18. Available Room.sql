CREATE FUNCTION udf_GetAvailableRoom(@HotelId INT, @DATE DATETIME2, @People INT) RETURNS VARCHAR(MAX)
AS BEGIN
   DECLARE @AvailableRoom NVARCHAR(MAX)= (SELECT TOP(1) CONCAT('Room ', r.Id, ': ', r.TYPE,' (', r.Beds, ' beds) - $', (h.BaseRate + r.Price) * @People)
                  FROM Hotels AS h
                  JOIN Rooms AS r
                  ON r.HotelId = h.Id
                  JOIN Trips AS t
                  ON t.RoomId = r.Id
                  WHERE @DATE NOT BETWEEN t.ArrivalDate AND t.ReturnDate
                  AND h.Id = @HotelId AND r.Beds > @People
                  AND t.CancelDate IS NULL
                  ORDER BY r.Price DESC)
 
        IF(@AvailableRoom IS NULL)
        BEGIN
           RETURN 'No rooms available'
        END
       
          RETURN @AvailableRoom
END

GO
  
SELECT dbo.udf_GetAvailableRoom(112, '2011-12-17', 2)
SELECT dbo.udf_GetAvailableRoom(94, '2015-07-26', 3)