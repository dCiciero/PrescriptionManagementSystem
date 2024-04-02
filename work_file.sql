SELECT top 5 p.[Name],p.[Condition], s.UnitCost FROM PharmaDrugs p  JOIN Stock s ON p.Id =  s.DrugId

SELECT top 5 p.[Name],p.[Condition], s.UnitCost FROM PharmaDrugs p  JOIN Stock s ON p.Id =  s.DrugId WHERE p.InStoke=1

SELECT top 5 p.*, s.Quantity, s.Expiry, s.UnitCost FROM PharmaDrugs p  JOIN Stock s ON p.Id =  s.DrugId

SELECT [Name],[Condition] FROM PharmaDrugs WHERE Id > 12

--DECLARE @Id INT, @Name NVARCHAR(80), @Condition NVARCHAR(200), @RunningTotal BigInt=0, @RowCnt BigInt = 0, @DrugId INT =13
--DECLARE drugCursor CURSOR FAST_FORWARD FOR SELECT [Id],[Name],[Condition] FROM PharmaDrugs WHERE Id > 19 --AND Id < 20
--OPEN drugCursor
--FETCH NEXT FROM drugCursor INTO @Id, @Name, @Condition
--WHILE @@FETCH_STATUS = 0
--BEGIN
--	PRINT str(@id) +' - '+ @Name + ' used for '+@Condition
--	INSERT INTO Stock ([Name],[Quantity],[Expiry],[UnitCost],[ReorderPoint],[MinStockLevel],[TaxPercentage],[DrugId],[IsDeleted])
--	VALUES (@Name, 800, DATEADD(dd, Ceiling(rand()*800) + 200, DATEDIFF(dd, 0, GETDATE())), ROUND(RAND(CHECKSUM(NEWID())) * (100), 2),50,25,0.00, @Id, 0)

--	FETCH NEXT FROM drugCursor INTO @Id, @Name, @Condition
--END
--CLOSE drugCursor
--DEALLOCATE drugCursor

--DECLARE @RowCnt BigInt = 0
--SELECT [Name],[Condition] FROM PharmaDrugs WHERE Id > 12
--SET @RowCnt = @@ROWCOUNT

--SELECT @RowCnt
--WHILE @DrugId <= @RowCnt
--BEGIN
--	INSERT INTO Stock ([Name],[Quantity],[Expiry],[UnitCost],[ReorderPoint],[MinStockLevel],[TaxPercentage],[DrugId],[IsDeleted])
--	VALUES ()
--END

SELECT GETDATE()

SELECT DATEADD(dd, 400, DATEDIFF(dd, 0, GETDATE()))

SELECT ROUND(RAND(CHECKSUM(NEWID())) * (100), 2)

SELECT ROUND(RAND(CHECKSUM(NEWID())) * (500), 0)

	
Select Ceiling(rand()*800) + 200




SELECT DateSold, SUM(AmountPaid) [Total Sale]
FROM Sales
WHERE DateSold BETWEEN @fromDate and @toDate
GROUP BY DateSold


SELECT * FROM SalesItem

SELECT * FROM Sales

SELECT TOP 5 Name, Quantity 
FROM Stock
WHERE QUANTITY < 25 AND IsDiscontinued=0


DECLARE @fromDate Datetime = '2024-03-01';
DECLARE @toDate Datetime = '2024-03-31';

SELECT TOP 5 P.Name, SUM(SalesItem.QtySold) AS Q 
FROM SalesItem
INNER JOIN PharmaDrugs P ON P.Id = SalesItem.DrugId
INNER JOIN Sales S ON S.Id = SalesItem.SaleId
WHERE DateSold BETWEEN @fromDate AND @toDate
GROUP BY P.Name
ORDER BY Q DESC

