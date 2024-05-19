CREATE TABLE [dbo].[category] (
    [categoryId] INT          IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([categoryId] ASC)
);

CREATE TABLE [dbo].[authors] (
    [authorId] INT          NOT NULL,
    [name]     VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([authorId] ASC)
);


CREATE TABLE [dbo].[bookCopies] (
    [bookId] INT NOT NULL,
    [copyId] INT IDENTITY (1, 1) NOT NULL,
    PRIMARY KEY CLUSTERED ([bookId] ASC, [copyId] ASC),
    CONSTRAINT [fk_bookCopies_books] FOREIGN KEY ([bookId]) REFERENCES [dbo].[books] ([bookId])
);


CREATE TABLE [dbo].[books] (
    [bookId]          INT           NOT NULL,
    [title]           VARCHAR (50)  NOT NULL,
    [isbn]            VARCHAR (50)  NULL,
    [categoryId]      INT           NOT NULL,
    [publicationYear] INT           NULL,
    [availability]    BIT           NULL,
    [description]     VARCHAR (300) NULL,
    [edition]         VARCHAR (15)  NULL,
    [authorId]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([bookId] ASC),
    CONSTRAINT [fk_categorizedby] FOREIGN KEY ([categoryId]) REFERENCES [dbo].[category] ([categoryId]),
    CONSTRAINT [fk_writtenby] FOREIGN KEY ([authorId]) REFERENCES [dbo].[authors] ([authorId])
);

CREATE TABLE [dbo].[users] (
    [UserId]      INT          IDENTITY (1, 1) NOT NULL,
    [firstName]   VARCHAR (20) NOT NULL,
    [lastName]    VARCHAR (20) NOT NULL,
    [homeAddress] VARCHAR (20) NULL,
    [phone]       VARCHAR (20) NULL,
    [email]       VARCHAR (20) NOT NULL,
    [password]    VARCHAR (30) NOT NULL,
    [isAdmin]     BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

CREATE TABLE [dbo].[borrow] (
    [bookId]     INT  NOT NULL,
    [userId]     INT  NOT NULL,
    [borrowDate] DATE NOT NULL,
    [returnDate] DATE NOT NULL,
    PRIMARY KEY CLUSTERED ([userId] ASC, [bookId] ASC),
    CONSTRAINT [fk_borrowingBook] FOREIGN KEY ([bookId]) REFERENCES [dbo].[books] ([bookId]),
    CONSTRAINT [fK_IsBorrowing] FOREIGN KEY ([userId]) REFERENCES [dbo].[users] ([UserId])
);

-- some reports for analysis of the trafic on the system
SELECT TOP 1 b.title, COUNT(br.bookId) AS BorrowCount
FROM dbo.borrow br
JOIN dbo.books b
ON br.bookId = b.bookId
GROUP BY b.title 
ORDER BY BorrowCount DESC;