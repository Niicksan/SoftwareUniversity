CREATE TABLE Products(
  BarcodeId INT PRIMARY KEY,
  Name VARCHAR(50)
)

CREATE TABLE Stock(
  Id INT PRIMARY KEY,
  Barcode INT,
  CONSTRAINT FK_Stock_Products FOREIGN KEY(BarcodeId)
  REFERENCES Products(BarcodeId) ON UPDATE CASCADE