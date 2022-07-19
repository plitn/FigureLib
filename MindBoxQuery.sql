CREATE TABLE Products (
	ID INT PRIMARY KEY,
	"Name" TEXT
	);

CREATE TABLE Categories (
	ID INT PRIMARY KEY,
	"Name" TEXT
	);

CREATE TABLE ProductsCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(ID),
	CategoryId INT FOREIGN KEY REFERENCES Categories(ID)
	);

INSERT INTO Products VALUES
	(1, 'Candy'),
	(2, 'Internship'),
	(3, 'Computer mouse'),
	(4, 'Keyboard'),
	(5, 'Water');

INSERT INTO Categories VALUES
	(1, 'Service'),
	(2, 'Food'),
	(3, 'Device');

INSERT INTO ProductsCategories VALUES
	(1, 1),
	(2, 1),
	(3, 3),
	(4, 3),
	(1, 3);

SELECT PRODUCT.Name, CATEGORY.Name
FROM Products PRODUCT 
LEFT JOIN ProductsCategories ON ProductId = PRODUCT.ID
LEFT JOIN Categories CATEGORY ON CategoryId = CATEGORY.ID;
