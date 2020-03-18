CREATE TABLE [dbo].[tblCustomer] (
    [CustomerID]    INT          NOT NULL,
    [FirstName]     VARCHAR (25) NOT NULL,
    [LastName]      VARCHAR (25) NOT NULL,
    [DateOfBirth]   DATE         NOT NULL,
    [Email]         VARCHAR (30) NOT NULL,
    [PhoneNumber]   VARCHAR (11) NULL,
    [Password]      VARCHAR (25) NOT NULL,
    [CardNo]        VARCHAR (16) NOT NULL,
    [CardDate]      DATE         NOT NULL,
    [StudentStatus] BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);

