CREATE TABLE [dbo].[Table]
(
	[CustomerID] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(20) NOT NULL, 
    [LastName] VARCHAR(20) NOT NULL, 
    [DateOfBirth] DATE NOT NULL, 
    [Email] VARCHAR(25) NOT NULL, 
    [PhoneNumber] VARCHAR(11) NULL, 
    [Password] VARCHAR(30) NOT NULL, 
    [CardNumber] VARCHAR(16) NOT NULL, 
    [CardDate] DATE NOT NULL, 
    [StudentStatus] BIT NOT NULL
)
