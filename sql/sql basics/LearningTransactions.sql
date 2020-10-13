Create Table Product
(
ProductID Int Primary Key,
Name Varchar(40),
Price Int,
Quantity Int
)
GO

 INSERT INTO Product VALUES(101, 'Product-1', 100, 10)
 INSERT INTO Product VALUES(102, 'Product-2', 200, 15)
 INSERT INTO Product VALUES(103, 'Product-3', 300, 20)
 INSERT INTO Product VALUES(104, 'Product-4', 400, 25)

 Select * From Product;
 Go

 Begin Transaction
	Insert Into Product Values(105, 'Product-5',500,30)
	Update Product Set Price = 350 Where ProductID = 103
	Delete From Product Where ProductID = 103
Commit Transaction
Go

Begin Transaction 
	Insert Into Product Values(106, 'Product-6',600,30)
	INSERT INTO Product VALUES(110,'Product-10',600, 30)
	INSERT INTO Product VALUES(110,'Product-10',600, 30)
	Update Product Set Price =550 Where ProductID = 105
	Delete From Product Where ProductID =104
	IF(@@ERROR > 0)
		Begin 
			Rollback Transaction 
		End
	Else
		Begin
			Commit Transaction
		End
