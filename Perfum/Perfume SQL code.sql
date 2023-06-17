CREATE DATABASE PerfumeStore;

USE PerfumeStore;

CREATE TABLE tbl_Products(
	productsId INT NOT NULL IDENTITY(100,1),
	productName VARCHAR(50) NOT NULL,
	price DECIMAL(6,2) NOT NULL,
	productDes VARCHAR(2000),
	stock INT DEFAULT 0,
	category CHAR(1) NOT NULL,
	PRIMARY KEY (productsId)
);

 

CREATE TABLE tbl_Customers(
	customersId INT NOT NULL IDENTITY(225 , 1),
	firstName VARCHAR(20) NOT NULL,
	lastName VARCHAR(20) NOT NULL,
	email VARCHAR(255) NOT NULL,
	pass VARCHAR(255) NOT NULL,
	phoneNumber VARCHAR(15),
	customerAddress VARCHAR(255),
	city VARCHAR(64),
	zip INT,
	country VARCHAR(64),
	PRIMARY KEY (customersId)
);


CREATE TABLE tbl_Admins(
	adminsId INT NOT NULL IDENTITY(1,100),
	username VARCHAR(64) NOT NULL,
	pass VARCHAR(255) NOT NULL,
	permission VARCHAR(20),
	PRIMARY KEY (adminsId)
);


CREATE TABLE tbl_Orders(
	ordersId INT NOT NULL IDENTITY(450,1),
	usersId INT NOT NULL,
	productsId INT NOT NULL,
	quantity INT NOT NULL,
	total DECIMAL(8,2) NOT NULL,
	orderDate DATE DEFAULT GETDATE(),
	FOREIGN KEY (usersId) REFERENCES tbl_Customers(customersId),
	FOREIGN KEY (productsId) REFERENCES tbl_Products(productsId)
);

CREATE TABLE tbl_Cart(
	cartId INT NOT NULL IDENTITY(1,1),
	customersId INT DEFAULT 0,
	productsId INT,
	quantity INT DEFAULT 0,
    FOREIGN KEY (customersId) REFERENCES tbl_Customers(customersId),
    FOREIGN KEY (productsId) REFERENCES tbl_Products(productsId)
);


INSERT INTO Products (productName , price , productDes , stock , category , productImage)

VALUES ('No. 5' , 350 , '5 was the first perfume launched by French couturier Gabrielle "Coco" Chanel in 1921. The scent formula for the fragrance was compounded by French-Russian chemist and perfumer Ernest Beaux. The design of its bottle has been an important part of the products branding.' , 3 , 'F');