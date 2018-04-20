CREATE TABLE [dbo].T_AccountBase
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Phone] VARCHAR(20) NOT NULL, 
    [PassWord] VARCHAR(100) NOT NULL, 
    [Classify] INT NOT NULL, 
    [Picture] VARCHAR(100) NOT NULL, 
    [OrderCount] INT NULL DEFAULT 0, 
    [TouristCount] INT NULL DEFAULT 0, 
    [ReimbursedCount] INT NULL DEFAULT 0, 
    [LoginCount] INT NULL DEFAULT 0, 
    [EnterpriseCount] INT NULL DEFAULT 0, 
    [DataSource] INT NULL DEFAULT 0, 
    [Nickname] VARCHAR(20) NOT NULL, 
    [BaseId] UNIQUEIDENTIFIER NOT NULL
)
