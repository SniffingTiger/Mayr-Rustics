CREATE TABLE [dbo].[Supplier] (
    [SourceCompID]              INT         NOT NULL,
    [CompName]                  NCHAR (50)  NOT NULL,
    [CompAddress]               NCHAR (100) NULL,
    [CompWebsite]               NCHAR (100) NULL,
    [CompPhone]                 NCHAR (20)  NULL,
    [PreferredPurchaseLocation] NCHAR (100) NULL,
    CONSTRAINT [PK_SourceCompany] PRIMARY KEY CLUSTERED ([SourceCompID] ASC)
);

