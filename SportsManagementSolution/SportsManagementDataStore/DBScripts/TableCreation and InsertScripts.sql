CREATE DATABASE SportsManagement

GO

CREATE TABLE SportsPersons
(
Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
FirstName nvarchar(50) NOT NULL,
LastName nvarchar(50) NOT NULL,
AssociatedSports nvarchar(50) NOT NULL,
PlayingProfessionallySince int NOT NULL,
GravatarUrl nvarchar(100) NULL,
IsActive bit not null,
CreatedOnUtc datetime not null,
CreatedBy int not null,
ModifiedOnUtc datetime,
ModifiedBy int
)
GO

INSERT INTO SportsPersons VALUES ('Andy','Smith','Tennis', 2000, '/images/andy.jpg',1,getdate(),100,null,null)

INSERT INTO SportsPersons VALUES ('John','Mendez','Football', 1998, '/images/john.jpg',1,getdate()+2,100,null,null)

INSERT INTO SportsPersons VALUES ('Lisa','Alex','Swimming', 2006, '/images/lisa.png',1,getdate()-3,100,null,null)

INSERT INTO SportsPersons VALUES ('Rita','Sharma','Cricket', 2008, '/images/rita.png',1,getdate(),100,null,null)

INSERT INTO SportsPersons VALUES ('Roger','Luke','Wrestling', 1999, '/images/roger.jpg',1,getdate(),100,null,null)

INSERT INTO SportsPersons VALUES ('Tara','Hanks','Archery', 2010, '/images/tara.png',1,getdate(),100,null,null)

GO