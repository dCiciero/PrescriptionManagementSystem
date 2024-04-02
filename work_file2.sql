SELECT * FROM Customer WHERE IsDeleted != 1 or IsDeleted is null

SELECT * FROM UserAccount
SELECT * FROM UserAccount WHERE Email='ivhurie01@yahoo.co.uk' and IsDeleted != 1 and StoreId=1
--UPDATE UserAccount SET IsDeleted=0 WHERE Id=1

SELECT TOP 10 * FROM PharmaDrugs
SELECT TOP 10 * FROM Stock