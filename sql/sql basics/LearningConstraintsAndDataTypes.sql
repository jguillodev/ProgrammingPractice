--The SQL Server supports the following data types

--    Integer data types
--    Decimal data types
--    Money / currency data types
--    Date and Time data types
--    Character data types
--	  Boolean Type
--    Binary data types
--    Special data types
Drop Table Employee;

--Default Constraint
Create Table Employee
(
	EmployeeID INT NOT NULL,
	LastName VARCHAR(255) NOT NULL,
	FirstName VARCHAR(255),
	Age INT,
	CITY VARCHAR(255) DEFAULT 'Mumbai',
	DateOfBirth date DEFAULT GETDATE(),
	SALARY DECIMAL(18, 2) DEFAULT 5000.00
);
GO

Insert Into Employee (EmployeeID,LastName,Age)
Values(1,'Rout',30);
GO

Select * FROM Employee;

--NOT NULL Constraint
Create Table Customer
(
	CustomerId INT NOT NULL,
	CustomerName varchar(30) NOT NULL,
	MOBNO Char(10) NOT NULL
)

INSERT customer VALUES (101, 'AA', '1111111111')--ALLOWED 
INSERT customer VALUES (101, 'AA', '2222222222')--ALLOWED 
INSERT customer VALUES (NULL, NULL, NULL)--NOTALLOWED

--Unique Constraint
Drop Table Customer;

Create Table Customer
(
	CustomerId INT UNIQUE,
	CustomerName varchar(30) UNIQUE,
	CustomerEmailID varchar(100) UNIQUE
)

INSERT customer  VALUES (10,  'AA',  'pranayakumar777@gmail.com');
INSERT customer VALUES (NULL, NULL, NULL)--ALLOWED 
INSERT customer VALUES (11, 'BB', 'pranayakumar7@gmail.com')--ALLOWED 
INSERT customer VALUES (NULL,  NULL, NULL) -- NOT ALLOWED 