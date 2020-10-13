
--Stored Procedure in SQL Serverr Without Parameter
CREATE PROCEDURE spDisplayWelcome
AS
Begin
	Print 'Welcome To Procedure in SQL Server'
End

Execute spDisplayWelcome

Drop Table Employee;
GO

Create Table Employee
(
	ID INT PRIMARY KEY,
	NAME VARCHAR(50),
	GENDER VARCHAR(50),
	DOB DATETIME,
	DEPTID INT
)
GO

-- Populate the Employee Table with test data
INSERT INTO Employee VALUES(1, 'Pranaya', 'Male','1996-02-29 10:53:27.060', 1)
INSERT INTO Employee VALUES(2, 'Priyanka', 'Female','1995-05-25 10:53:27.060', 2)
INSERT INTO Employee VALUES(3, 'Anurag', 'Male','1995-04-19 10:53:27.060', 2)
INSERT INTO Employee VALUES(4, 'Preety', 'Female','1996-03-17 10:53:27.060', 3)
INSERT INTO Employee VALUES(5, 'Sambit', 'Male','1997-01-15 10:53:27.060', 1)
INSERT INTO Employee VALUES(6, 'Hina', 'Female','1995-07-12 10:53:27.060', 2)
GO

CREATE PROCEDURE spGetEmployee
AS 
	Begin
		Select Name, Gender, DOB 
		from Employee
	End

Exec sp_helptext spGetEmployee;
Go

Exec spGetEmployee;
GO
--How to change the body of a stored procedure
--User Alter procedure to change the body

Alter Procedure spGetEmployee
AS
Begin 
	Select Name, Gender,DOB
	FROM Employee
	Order By Name
End
GO

--To change the procedure name
Exec sp_rename 'spGetEmployee', 'spGetEmployee1';
GO

Drop Procedure spGetEmployee1;
Go

--Stored Procedure for adding teo variables value
Create Procedure spAddTwoNumbers(@no1 INT, @no2 INT)
AS 
	Begin
		Declare @Result INT
		SET @Result = @no1 + @no2
		Print 'Result Is: ' + CAST(@REsult AS VARCHAR)
	End
GO

Exec sp_helptext 'spAddTwoNumbers';
Go

Exec spAddTwoNumbers 10, 20;
Go

Create Procedure spGetEmployeesByGenderAndDepartment
	@Gender Varchar(20),
	@DeptID INT
AS
	Begin
		SELECT Name, Gender, DOB, DeptID
		FROM Employee
		WHERE Gender = @Gender AND DEPTID = @DeptID
	END
GO

Exec sp_helptext 'spGetEmployeesByGenderAndDepartment';
GO 

Exec spGetEmployeesByGenderAndDepartment 'Male',1;
GO

Create Procedure spUpdateEmployeeByID
(
	@ID INT,
	@NAME VARCHAR(50),
	@GENDER VARCHAR(50),
	@DOB DATETIME,
	@DEPTID INT
)
AS
	BEGIN
		UPDATE Employee SET
			NAME = @NAME,
			GENDER = @GENDER,
			DOB = @DOB,
			DEPTID = @DeptID
		Where ID = @ID
	END
GO

Exec sp_helptext 'spUpdateEmployeeByID';
Go

EXECUTE spUpdateEmployeeByID 3, 'Palak', 'Female', '1994-06-17 10:53:27.060', 3;
Go

-- Output 
Create Procedure spGetResult
(
	@No1 INT,
	@No2 INT,
	@Result INT Output
)
AS
	Begin
		Set @Result = @No1 + @No2
	End
Go

Exec sp_helptext 'spGetResult';

Declare @Result INT
Execute spGetResult 7,4, @Result Out;
Go

Drop Table Employee;
Go

-- Create Employee Table
CREATE TABLE Employee
(
  ID INT PRIMARY KEY,
  Name VARCHAR(50),
  Gender VARCHAR(50),
  DOB DATETIME,
  DeptID INT
)
GO

-- Populate the Employee Table with test data
INSERT INTO Employee VALUES(1, 'Pranaya', 'Male','1996-02-29 10:53:27.060', 1)
INSERT INTO Employee VALUES(2, 'Priyanka', 'Female','1995-05-25 10:53:27.060', 2)
INSERT INTO Employee VALUES(3, 'Anurag', 'Male','1995-04-19 10:53:27.060', 2)
INSERT INTO Employee VALUES(4, 'Preety', 'Female','1996-03-17 10:53:27.060', 3)
INSERT INTO Employee VALUES(5, 'Sambit', 'Male','1997-01-15 10:53:27.060', 1)
INSERT INTO Employee VALUES(6, 'Hina', 'Female','1995-07-12 10:53:27.060', 2)
GO

Create Procedure spGetEmployeeCountByGender
(
	@Gender VARCHAR(30),
	@EmployeeCount INT OUTPUT
)
AS
	Begin
		SELECT @EmployeeCount = COUNT(ID)
		FROM Employee
		Where Gender = @Gender
	END
GO

Exec sp_helptext 'spGetEmployeeCountByGender';
Go

Declare @EmployeeTotal INT
Execute spGetEmployeeCountByGender 'Male', @EmployeeTotal
IF (@EmployeeTotal IS NULL)
	Print '@EmployeeTotal IS NULL'
Else
	Print '@EmployeeTotall IS NOT NULL'
Go

Declare @EmployeeTotal INT
Execute spGetEmployeeCountByGender 'Male', @EmployeeTotal Output
IF (@EmployeeTotal IS NULL)
	Print '@EmployeeTotal IS NULL'
Else
	Print '@EmployeeTotall IS NOT NULL'
	Print @EmployeeTotal
Go