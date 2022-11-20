CREATE DATABASE DoAnTotNghiep
GO
USE DoAnTotNghiep
GO	
CREATE TABLE UseLogin
(
	userName nvarchar(50),
	userPass nvarchar(50)
)
GO	
ALTER TABLE dbo.UseLogin ALTER COLUMN userName NVARCHAR(50) NOT NULL
GO 
-- Add constraint -> primary key
ALTER TABLE dbo.UseLogin ADD CONSTRAINT PK_User PRIMARY KEY (userName)
GO 
INSERT dbo.UseLogin
(
    userName,
    userPass
)
VALUES
(   N'truongdn', -- userName - nvarchar(50)
    N'123456'  -- userPass - nvarchar(50)
)
GO	
INSERT dbo.UseLogin
(
    userName,
    userPass
)
VALUES
(   N'hant', -- userName - nvarchar(50)
    N'123456'  -- userPass - nvarchar(50)
)
GO 
SELECT	* FROM	dbo.UseLogin
GO	
CREATE TABLE Data
(
	ID INT not null IDENTITY(1,1),
	dayTime DATETIME not null,
	typeProduct INT not null,
	CONSTRAINT PK_Data
	PRIMARY KEY (ID, dayTime)
)
GO 
INSERT dbo.Data(dayTime, typeProduct)
-- output inserted.ID
VALUES
(--   1,         -- ID - int
    GETDATE(), -- dayTime - datetime
   0          -- typeProduct - int
)
INSERT dbo.Data(dayTime, typeProduct)
VALUES
(--   2,         -- ID - int
    GETDATE(), -- dayTime - datetime
    1          -- typeProduct - int
)
INSERT dbo.Data(dayTime, typeProduct)
VALUES
(--   3,         -- ID - int
    GETDATE(), -- dayTime - datetime
    0         -- typeProduct - int
)
GO 
SELECT * FROM dbo.Data
--SELECT * FROM  Data WHERE dayTime BETWEEN '2022-11-12 10:00:00' AND '2022-11-13 10:00:00'
--                       ORDER BY dayTime;
--SELECT * FROM Data WHERE typeProduct = 2 
--GO 
CREATE TABLE SumData
(
	dayTime DATE NOT NULL,
	typeProduct INT NOT NULL,
	quantity INT not null
	CONSTRAINT PK_SumData
	PRIMARY KEY (dayTime, typeProduct)
)
GO 
INSERT dbo.SumData(dayTime, typeProduct, quantity)
VALUES
(   GETDATE(), -- dayTime - datetime
    0,         -- typeProduct - int
    675355          -- quantity - int
)
INSERT dbo.SumData(dayTime, typeProduct, quantity)
VALUES
(   GETDATE(), -- dayTime - datetime
    1,         -- typeProduct - int
    886941          -- quantity - int
)
INSERT dbo.SumData(dayTime, typeProduct, quantity)
VALUES
(   GETDATE(), -- dayTime - datetime
    2,         -- typeProduct - int
    699802          -- quantity - int
)
GO	
SELECT * FROM dbo.SumData

DELETE TOP(3) FROM Data

UPDATE SumData SET quantity = quantity + 1 
	WHERE DAY(SumData.dayTime) = (SELECT TOP(1) DAY(Data.dayTime) FROM Data) 
	AND MONTH(SumData.dayTime) = (SELECT TOP(1) MONTH(Data.dayTime) FROM Data) 
	AND SumData.typeProduct = (SELECT TOP(1) Data.typeProduct FROM Data) 

select
