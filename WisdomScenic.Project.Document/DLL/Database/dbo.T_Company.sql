CREATE TABLE [dbo].[T_Company] (
    [Id]              UNIQUEIDENTIFIER NOT NULL,
    [CompanyName]     VARCHAR (100)    NOT NULL,
    [Status]          INT              NOT NULL,
    [ProvinceId]      INT              NOT NULL,
    [CityId]          INT              NOT NULL,
    [DistrictId]      INT              NOT NULL,
    [Address]         VARCHAR (200)    NULL,
    [ContactPhonel]   VARCHAR (20)     NULL,
    [BusinessChapter] VARCHAR (100)    NOT NULL,
    [MemberCount]     INT              NULL DEFAULT 0,
    [ProductCount]    INT              NULL DEFAULT 0,
    [OrderCount]      INT              NULL DEFAULT 0,
    [TouristCount]    INT              NULL DEFAULT 0,
    [ReimbursedCount] INT              NULL DEFAULT 0,
    [BaseId]          UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

