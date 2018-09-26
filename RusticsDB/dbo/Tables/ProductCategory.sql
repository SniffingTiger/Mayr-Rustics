CREATE TABLE [dbo].[ProductCategory] (
    [CategoryID] INT           IDENTITY (1, 1) NOT NULL,
    [Category]   NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_ProductCategories] PRIMARY KEY CLUSTERED ([CategoryID] ASC)
);

