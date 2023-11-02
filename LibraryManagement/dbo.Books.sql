CREATE TABLE [dbo].[Books] (
    [Book_ID]                            INT          NOT NULL,
    [International Standard Book number] INT          NULL,
    [Book_Name]                          VARCHAR (50) NULL,
    [Author]                             VARCHAR (50) NULL,
    [Publisher]                          VARCHAR (50) NULL,
    [Department_ID]                      INT          NULL,
    [Borrower_ID]                        INT          NULL,
    PRIMARY KEY CLUSTERED ([Book_ID] ASC)
);

