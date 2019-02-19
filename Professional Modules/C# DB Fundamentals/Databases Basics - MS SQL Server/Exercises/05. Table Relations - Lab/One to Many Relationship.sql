CREATE TABLE Mountains(
  MountainID INT PRIMARY KEY,
  MountainName VARCHAR(50)
)
CREATE TABLE Peaks(
  PeakId INT PRIMARY KEY,
  MountainID INT,
  CONSTRAINT FK_Peaks_Mountains 
  FOREIGN KEY (MountainID)   REFERENCES Mountains(MountainID)
  )