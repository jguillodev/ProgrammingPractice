CREATE TABLE Student 
( 
    No Int,
	Name VARCHAR(50)
); 
GO 

Alter Table Student ALTER Column NAme VARCHAR(100);
GO

Alter Table Student Alter Column No Int NOT NULL;
GO

Alter Table Student ADD Branch VARCHAR(20);
GO

ALter Table Student Drop Column Branch;
GO

SP_RENAME 'Student.Name', 'StudentName';
GO

SP_RENAME 'Student','StudentDetails';
GO

Truncate Table StudentDetails;
GO

--Drop Table StudentDetails;