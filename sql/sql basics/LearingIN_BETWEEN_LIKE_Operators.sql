--Create database EmployeeDB
Create database EmployeeDB
Go

Use EmployeeDB
Go

-- Create Employee table
CREATE TABLE Employee
(
  ID INT PRIMARY KEY IDENTITY(1,1),
  Name VARCHAR(100),
  EmailID VARCHAR(100),
  Gender VARCHAR(100),
  Department VARCHAR(100),
  Salary INT,
  Age INT,
  CITY VARCHAR(100)
)
GO

--Insert some test data into Employee table
INSERT INTO Employee VALUES('Pranaya','Pranaya@g.com','Male', 'IT', 25000, 30,'Mumbai')
INSERT INTO Employee VALUES('Tarun','Tarun@g.com','Male', 'Payroll', 30000, 27,'Odisha')
INSERT INTO Employee VALUES('Priyanka','Priyanka@g.com','Female', 'IT', 27000, 25,'Bangalore')
INSERT INTO Employee VALUES('Preety','Preety@g.com','Female', 'HR', 35000, 26,'Bangalore')
INSERT INTO Employee VALUES('Ramesh','Ramesh@g.com','Male','IT', 26000, 27,'Mumbai')
INSERT INTO Employee VALUES('Pramod','Pramod@g.com','Male','HR', 29000, 28,'Odisha')
INSERT INTO Employee VALUES('Anurag','Anurag@g.com','Male', 'Payroll', 27000, 26,'Odisha')
INSERT INTO Employee VALUES('Hina','Hina@g.com','Female','HR', 26000, 30,'Mumbai')
INSERT INTO Employee VALUES('Sambit','Sambit@g.com','Male','Payroll', 30000, 25,'Odisha')
INSERT INTO Employee VALUES('Manoj','Manoj@g.com','Male','HR', 30000, 28,'Odisha')
INSERT INTO Employee VALUES('Sara',' Sara@g.com','Female', 'Payroll', 28000, 27,'Mumbai')
INSERT INTO Employee VALUES('Lima','Lima@g.com','Female','HR', 30000, 30,'Bangalore')
INSERT INTO Employee VALUES('Dipak','Dipak@g.com','Male','Payroll', 32000, 25,'Bangalore')
GO

-- Between Operator
Select * From Employee Where ID Between 3 and 7;
GO

-- Not Between 
Select * From Employee Where ID Not Between 3 And 7;
GO

--IN Operator
Select * From Employee Where Department IN ('IT','HR');
GO

--Not In Operator
Select * From Employee Where Department Not In ('IT','HR');
Go

--LIKE Operator 
Select * From Employee Where Name Like 'P%';
GO

Select * From Employee Where Name Like '%a';
Go

Select * From Employee Where Name Like '%am%';
Go

-- display employee details whose name contains 3 characters.
Select * From Employee Where Name Like '___';
Go

--display employee details whose name contains ‘A’ character.
Select * From Employee Where Name Like '%A%';
Go

--display employee details whose name starts with ‘P’ character and ends with ‘A’ character.
Select * From Employee Where Name Like 'P%A';

--display employee details whose name starts with J, H, K, U characters.
Select * From Employee Where Name Like '[J,H,K,U,]%'
Go

--display employee details whose name not start with A to Z characters.
Select * From Employee Where Name Like'[^D-Z]%';
Go
