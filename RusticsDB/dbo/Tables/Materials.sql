CREATE TABLE [dbo].[Materials] (
    [MatID]           INT        NOT NULL,
    [Description]     NCHAR (10) NOT NULL,
    [Color]           NCHAR (10) NULL,
    [Price]           MONEY      NULL,
    [SourceCompID]    INT        NULL,
    [AmountAvailable] NCHAR (10) NULL,
    CONSTRAINT [PK_Materials] PRIMARY KEY CLUSTERED ([MatID] ASC),
    CONSTRAINT [FK_Materials_SourceCompany] FOREIGN KEY ([SourceCompID]) REFERENCES [dbo].[Supplier] ([SourceCompID])
);

