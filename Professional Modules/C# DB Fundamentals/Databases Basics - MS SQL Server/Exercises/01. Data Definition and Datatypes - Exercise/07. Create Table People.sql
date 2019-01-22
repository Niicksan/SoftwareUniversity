CREATE TABLE People (
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	[Name] NVARCHAR(200) NOT NULL,
	Picture IMAGE,
	Height FLOAT(2),
	[Weight] FLOAT(2),  
	Gender VARCHAR(1) NOT NULL CHECK (Gender IN ('m','f')),
	Birthdate datetime NOT NULL,
	Biography text
)

INSERT INTO People ([Name], Picture, Height, [Weight], Gender, Birthdate, Biography) VALUES
('Gosho Bunov', '/home/Pictures', '1.78', '62.50', 'm', '1997-02-11', 'Gosho bonov is a realy good friend. He is cool and fuuny.'),
('Emilia Nedialkova', '/download/Pictures/Emy', '1.65', '55.80', 'f', '1998-07-08', 'Emy is the most beautiful, ambitions, smart girl i have ever met.'),
('Nikolay Koev', '/Nik/Pictures', '1.65', '58.50', 'm', '1997-03-12', 'Nik is realy a wonderful person. He is smart and shy, but he is very nice and polite, with an amazing smile.'),
('Demi Lovato', '/home/Demi', '1.61', '60.10', 'f', '1992-08-26', 'Demetria Devonne Lovato is an American singer, songwriter, and actress.'),
('Selena Gpmez', '/home/Selena', '1.65', '54.20', 'f', '1992-07-22', 'Selena Marie Gomez is an American singer, actress, and producer.')