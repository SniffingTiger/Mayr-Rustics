CREATE TABLE [dbo].[Product] (
    [ProductID]    INT            IDENTITY (1, 1) NOT NULL,
    [ProductName]  NVARCHAR (50)  NOT NULL,
    [Alias]        NVARCHAR (50)  NULL,
    [CreateDate]   DATETIME       CONSTRAINT [DF_Products_CreateDate] DEFAULT (getdate()) NOT NULL,
    [ModifyDate]   DATETIME       CONSTRAINT [DF_Products_ModifyDate] DEFAULT (getdate()) NOT NULL,
    [HowTo]        NVARCHAR (MAX) NULL,
    [Price]        MONEY          NULL,
    [Weight]       DECIMAL (3, 1) NULL,
    [Size]         NVARCHAR (50)  NULL,
    [CategoryID]   INT            NULL,
    [AmountOnHand] INT            NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([ProductID] ASC),
    CONSTRAINT [FK_Products_ProductCategories] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[ProductCategory] ([CategoryID])
);

