-- 1. show all invoices of customers from brazil (mailing address not billing)
SELECT Invoice.InvoiceId, Customer.CustomerId, Customer.FirstName, Customer.LastName,  Customer.[Address] 
From Invoice
INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId;

-- 2. show all invoices together with the name of the sales agent of each one
SELECT Invoice.InvoiceId, Employee.EmployeeId,Employee.FirstName, Employee.LastName, Employee.Title 
FROM Invoice
CROSS JOIN Employee;

-- 3. show all playlists ordered by the total number of tracks they have
SELECT Playlist.[Name], COUNT(PlaylistTrack.TrackId) AS [TotalTracks] FROM Playlist
Left JOIN PlaylistTrack ON Playlist.PlaylistId = PlaylistTrack.PlaylistId
GROUP BY Playlist.[Name]
ORDER BY TotalTracks;

-- 5. how many customers are assigned to each sales agent?
SELECT COUNT(Customer.CustomerId) AS [CustomersAssigned], Employee.EmployeeId 
FROM Customer
RIGHT JOIN Employee ON Customer.SupportRepId = Employee.EmployeeId
GROUP BY Employee.EmployeeId;

-- 6. which track was purchased the most since 2010?
SELECT COUNT(InvoiceLine.InvoiceId) AS [Purchases by Track Since 2010], Track.[Name]  
FROM InvoiceLine
LEFT JOIN Invoice ON InvoiceLine.InvoiceId = Invoice.InvoiceId
LEFT JOIN Track ON InvoiceLine.TrackId = Track.TrackId
WHERE YEAR(Invoice.InvoiceDate) >= '2010'
GROUP BY Track.[Name]
ORDER BY COUNT(Invoice.InvoiceId) DESC;

-- 8. which customers have the same initials as at least one other customer?


