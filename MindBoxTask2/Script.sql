-- Products
CREATE TABLE Products (Id INTEGER UNIQUE NOT NULL PRIMARY KEY, Name VARCHAR NOT NULL);
INSERT INTO Products (Id, Name) VALUES (1, 'Phone');
INSERT INTO Products (Id, Name) VALUES (2, 'Computer');
INSERT INTO Products (Id, Name) VALUES (3, 'Banana');
INSERT INTO Products (Id, Name) VALUES (4, 'Car');

-- Categories
CREATE TABLE Categories (Id INTEGER NOT NULL UNIQUE PRIMARY KEY, Name VARCHAR NOT NULL);
INSERT INTO Categories (Id, Name) VALUES (1, 'Electronics');
INSERT INTO Categories (Id, Name) VALUES (2, 'Food');

-- Market
CREATE TABLE Market (ProductID INTEGER, CategoryID INTEGER);
INSERT INTO Market (ProductID, CategoryID) VALUES (1, 1);
INSERT INTO Market (ProductID, CategoryID) VALUES (2, 1);
INSERT INTO Market (ProductID, CategoryID) VALUES (3, 2);
INSERT INTO Market (ProductID, CategoryID) VALUES (4, NULL);

-- Query
SELECT Products.Name AS Product, Categories.Name AS Category FROM Market
JOIN Products ON Market.ProductID = Products.Id
LEFT JOIN Categories ON Market.CategoryID = Categories.Id
