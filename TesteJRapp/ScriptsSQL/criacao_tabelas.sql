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

ALTER TABLE `purchaseorder`
  ADD CONSTRAINT `purchaseorder_ibfk_1` FOREIGN KEY (`IdClient`) REFERENCES `infocliente` (`IdClient`),
  ADD CONSTRAINT `purchaseorder_ibfk_2` FOREIGN KEY (`IdProduct`) REFERENCES `product` (`IdProduct`);
COMMIT;


INSERT INTO `product` (`IdProduct`, `Name`, `Description`, `Price`, `RegistrationDate`) VALUES
(5, 'Caneta Bic Azul - UN', 'Caneta azul, marca BIC, uma unidade.', '2,15', '2023-03-10 15:07:58'),
(6, 'Lápis preto UN', 'Lápis de grafite preto.', '1,11', '2023-03-10 15:18:22'),
(7, 'Post-IT CX', 'Post It caixa, 10 unidades, multiplas cores.  ', '15,26', '2023-03-10 15:18:22'),
(8, 'Grampeador UN', 'Grampeador 26/6.', '21,21', '2023-03-10 15:18:22'),
(9, 'Apontador UN', 'Unidade de Apontador, multiplas cores.', '5,00', '2023-03-10 15:32:58');


INSERT INTO `infocliente` (`IdClient`, `Name`, `LastName`, `PhoneNumber`) VALUES
(1, 'Jean', 'Van Dame', '(555) 012-3233'),
(2, 'Joao', 'Gomes', '(000) 000-0000'),
(3, 'Bruno', 'de Barros', '( 55) 996-8523'),
(4, 'Vin', 'Diesel', '(555) 253-666'),
(5, 'Michael', 'Jackson', '(555) 012-3456');
