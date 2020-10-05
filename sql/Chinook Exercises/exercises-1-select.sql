SELECT CustomerId, FirstName, LastName, Country FROM dbo.Customer
WHERE NOT Country = 'USA';

SELECT CustomerId, FirstName, LastName, Country FROM dbo.Customer
WHERE Country = 'Brazil';

SELECT * FROM [dbo].[Employee]
WHERE Title = 'Sales Support Agent';

SELECT * FROM Invoice;

SELECT COUNT(*) As [Total2009Invoices], SUM(Total) AS [TotalSales2009] FROM Invoice
WHERE YEAR(InvoiceDate) = '2009';

SELECT COUNT(*) FROM InvoiceLine
Where InvoiceId = 37;

SELECT COUNT(InvoiceId) AS [InvoicesPerCountry], BillingCountry FROM Invoice
GROUP BY BillingCountry;

SELECT COUNT(InvoiceId) AS [InvoicesPerCountry], SUM(Total) AS TotalSales, BillingCountry FROM Invoice
GROUP BY BillingCountry



