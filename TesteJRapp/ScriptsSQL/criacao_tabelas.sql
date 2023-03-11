CREATE TABLE product (
    IdProduct INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Description VARCHAR(255) NULL,
    Price VARCHAR(30) NOT NULL,
    RegistrationDate DATETIME
) COMMENT='Tabela básica de cadastro de produtos';

CREATE TABLE infocliente (
  IdClient INT AUTO_INCREMENT PRIMARY KEY,
  Name varchar(40) NOT NULL,
  LastName varchar(40) NOT NULL,
  PhoneNumber varchar(20) NOT NULL
) COMMENT='Tabela básica de cadastro de clientes';

CREATE TABLE purchaseorder (
   IdOrder INT PRIMARY KEY,
   IdClient INT,
   IdProduct INT,
   OrderDate DATE,
   TotalAmount DECIMAL(10,2),
   FOREIGN KEY (IdClient) REFERENCES infocliente(IdClient),
   FOREIGN KEY (IdProduct) REFERENCES product(IdProduct)
) COMMENT='Tabela de pedidos';