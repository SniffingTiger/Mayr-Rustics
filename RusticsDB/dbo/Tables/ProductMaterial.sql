CREATE TABLE [dbo].[ProductMaterial] (
    [ProductID]    INT NOT NULL,
    [MatID]        INT NOT NULL,
    [ProductMatID] INT IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_ProductMaterials_1] PRIMARY KEY CLUSTERED ([ProductMatID] ASC),
    CONSTRAINT [FK_ProductMaterials_Products] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ProductID]),
    CONSTRAINT [FK_ProductMaterials_to_Materials] FOREIGN KEY ([MatID]) REFERENCES [dbo].[Materials] ([MatID])
);


GO
CREATE NONCLUSTERED INDEX [NonClusteredIndex-ByProductID]
    ON [dbo].[ProductMaterial]([ProductID] ASC, [ProductMatID] ASC);


GO
CREATE NONCLUSTERED INDEX [NonClusteredIndex-ByMatID]
    ON [dbo].[ProductMaterial]([MatID] ASC, [ProductMatID] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'FK ''MatID'' in dbo.ProductMaterials links to the PK ''MatID'' in dbo.Materials', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ProductMaterial', @level2type = N'CONSTRAINT', @level2name = N'FK_ProductMaterials_to_Materials';

