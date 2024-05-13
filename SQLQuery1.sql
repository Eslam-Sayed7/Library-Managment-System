CREATE TABLE category(
	categoryId INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(20) NOT NULL
);

CREATE TABLE authors(
	authorId INT PRIMARY KEY,
	[name] VARCHAR(20) NOT NULL
);

CREATE TABLE bookcopies(
	bookId INT,
	[copy] INT

	CONSTRAINT fk_bookCopies FOREIGN KEY (bookId)
	REFERENCES books(bookId) ON DELETE NO ACTION
);

CREATE TABLE books(
	bookId INT PRIMARY KEY ,
	title VARCHAR(50) NOT NULL,
	isbn VARCHAR(50),
	categoryId INT NOT NULL,
	publicationYear INT,
	[availability] BIT,
	[description] VARCHAR(300),
	edition VARCHAR(15),
	authorId INT NOT NULL, 
	
	CONSTRAINT fk_categorizedby FOREIGN KEY (categoryId) 
	REFERENCES category(categoryId) ON DELETE NO ACTION,

	--CONSTRAINT fk_bookCopies FOREIGN KEY (bookId)
	--REFERENCES bookcopies(bookId) ON DELETE NO ACTION,

	CONSTRAINT fk_writtenby FOREIGN KEY (authorId)
	REFERENCES authors(authorId) ON DELETE NO ACTION
);

CREATE TABLE users (
	UserId INT PRIMARY KEY IDENTITY(1,1),
	firstName VARCHAR(20) NOT NULL,
	lastName VARCHAR (20) NOT NULL,
	homeAddress VARCHAR(20),
	phone VARCHAR(20),
	email VARCHAR (20) NOT NULL,
	isAdmin BIT NOT NULL --boolean value indicate if the user is and admin  
);	

CREATE TABLE borrow(
	borrowingTransaction INT PRIMARY KEY IDENTITY(1,1),
	bookId INT,
	userId INT NOT NULL,
	borrowDate DATE NOT NULL,
	returnDate DATE NOT NULL, 

	CONSTRAINT fk_borrowingBook FOREIGN KEY (bookId)
	REFERENCES books(bookId) ON DELETE NO ACTION,

	CONSTRAINT fk_IsBorrowing FOREIGN KEY (userId)
	REFERENCES users(UserId) ON DELETE NO ACTION
);

-- some reports for analysis of the trafic on the system
