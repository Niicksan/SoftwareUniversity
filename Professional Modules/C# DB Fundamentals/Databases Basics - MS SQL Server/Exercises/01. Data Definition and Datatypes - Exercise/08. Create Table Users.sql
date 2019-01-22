CREATE TABLE Users (
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	Username VARCHAR(30) NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture IMAGE,
	LastLoginTime TIME,
	IsDeleted BIT
)

INSERT INTO Users (Username, [Password], ProfilePicture, LastLoginTime, IsDeleted) VALUES
('nisan', '123456789', '/download/Pictures/', '12:33:52', 1),
('nik', '33333326', '/documents/Image/', '16:51:36', 1),
('NoLimit', 'nolimit', '/download/desktop/', '22:43:58', 0),
('loveyou', 'lovelovelove', '/user/Pictures/', '11:34:55', 1),
('lost', 'iagh3tia', '/download/lost/', '20:30:40', 0)