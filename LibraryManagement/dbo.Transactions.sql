CREATE TABLE [dbo].[Transactions] (
    [Transaction_number] INT          IDENTITY (1, 1) NOT NULL,
    [Date]               DATE         NULL,
    [time]               TIME (7)     NULL,
    [Borrow_ID]          INT          NULL,
    [Book_ID]            INT          NULL,
    [Authorized_by]      VARCHAR (50) NULL,
    [Due_Date]           DATE         NULL,
    [Borrow_status]      BIT          NULL,
    PRIMARY KEY CLUSTERED ([Transaction_number] ASC)
);

