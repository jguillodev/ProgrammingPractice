CREATE DATABASE EmployeeDB
GO
USE EmployeeDB
GO
CREATE TABLE EmployeeIndia
(
  ID INT PRIMARY KEY,
  Name VARCHAR(50),
  Gender VARCHAR(10),
  Department VARCHAR(50)
)
GO
INSERT INTO EmployeeIndia VALUES(1, 'Pranaya', 'Male','IT')
INSERT INTO EmployeeIndia VALUES(2, 'Priyanka', 'Female','IT')
INSERT INTO EmployeeIndia VALUES(3, 'Preety', 'Female','HR')
INSERT INTO EmployeeIndia VALUES(4, 'Subrat', 'Male','HR')
INSERT INTO EmployeeIndia VALUES(5, 'Anurag', 'Male','IT')
GO
CREATE TABLE EmployeeUK
(
  ID INT PRIMARY KEY,
  Name VARCHAR(50),
  Gender VARCHAR(10),
  Department VARCHAR(50)
)
GO
INSERT INTO EmployeeUK VALUES(1, 'James', 'Male','IT')
INSERT INTO EmployeeUK VALUES(2, 'Priyanka', 'Female','IT')
INSERT INTO EmployeeUK VALUES(3, 'Sara', 'Female','HR')
INSERT INTO EmployeeUK VALUES(4, 'Subrat', 'Male','HR')
INSERT INTO EmployeeUK VALUES(5, 'Pam', 'Female','HR')
GO

Select ID, Name, Gender, Department From EmployeeIndia
Union ALL
Select ID, Name, Gender, Department From EmployeeUK;
GO

Select ID, Name, Gender, Department From EmployeeIndia
Union 
Select ID, Name, Gender, Department From EmployeeUK;
GO

Select ID, Name, Gender, Department From EmployeeIndia
Except 
Select ID, Name, Gender, Department From EmployeeUK;
GO

-- SQL script to create Employees table
Create table Employees
(
    Id int identity primary key,
    Name nvarchar(100),
    Gender nvarchar(10),
    Salary int
)
Go

Insert into Employees values ('Mark', 'Male', 52000)
Insert into Employees values ('Mary', 'Female', 55000)
Insert into Employees values ('Steve', 'Male', 45000)
Insert into Employees values ('John', 'Male', 40000)
Insert into Employees values ('Sara', 'Female', 48000)
Insert into Employees values ('Pam', 'Female', 60000)
Insert into Employees values ('Tom', 'Male', 58000)
Insert into Employees values ('George', 'Male', 65000)
Insert into Employees values ('Tina', 'Female', 67000)
Insert into Employees values ('Ben', 'Male', 80000)
Go