CREATE TABLE [dbo].[Borrow_Table] (
    [Borrow_ID] INT          NOT NULL,
    [Name]      VARCHAR (20) NULL,
    [Address]   VARCHAR (50) NULL,
    [Phone_no.] INT          NULL,
    [Book1_ID]  INT          NULL,
    [Book2_ID]  INT          NULL,
    PRIMARY KEY CLUSTERED ([Borrow_ID] ASC),
    CONSTRAINT [FK_Borrow_Table_ToTable] FOREIGN KEY ([Book1_ID]) REFERENCES [dbo].[Books] ([Book_ID]),
    CONSTRAINT [FK_Borrow_Table_ToTable_1] FOREIGN KEY ([Book2_ID]) REFERENCES [dbo].[Books] ([Book_ID])
);

