CREATE LOGIN [pharma_user] WITH PASSWORD = 'test123@';
CREATE USER [pharma_user] FOR LOGIN [pharma_user];
exec sp_addrolemember 'db_owner', 'pharma_user'

--Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PharmaZeal;Integrated Security=true;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
--Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PharmaZeal;User id=pharma_user; password=test123@;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False