use nikepushup;

CREATE TABLE categoria (
  id VARCHAR(50) PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL
);

CREATE TABLE producto (
  id INT PRIMARY KEY,
  idCategoria VARCHAR(50),
  titulo VARCHAR(100) NOT NULL,
  imagen VARCHAR(255),
  precio FLOAT NOT NULL,
  stock INT NOT NULL,
  FOREIGN KEY (idCategoria) REFERENCES categoria(id)
);

CREATE TABLE cliente (
  id INT PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL,
  apellido VARCHAR(50),
  telefono VARCHAR(10),
  userId INT
);

CREATE TABLE factura (
  id INT PRIMARY KEY, 
  idCliente INT, 
  total FLOAT NOT NULL, 
  FOREIGN KEY (idCliente) REFERENCES cliente(id)
);

CREATE TABLE productosventa (
  id INT PRIMARY KEY, 
  idFactura INT, 
  idProducto INT, 
  cantidad INT NOT NULL, 
  subtotal FLOAT NOT NULL, 
  FOREIGN KEY (idFactura) REFERENCES factura(id), 
  FOREIGN KEY (idProducto) REFERENCES producto(id)
);

CREATE TABLE rol (
  id INT PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL
);

CREATE TABLE usuario (
  id INT PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL,
  email VARCHAR(100) NOT NULL,
  password VARCHAR(255) NOT NULL
);

CREATE TABLE rolusuario (
  idUsuarioFk INT,
  idRolFk INT,
  PRIMARY KEY (idUsuarioFk, idRolFk),
  FOREIGN KEY (idUsuarioFk) REFERENCES usuario(id),
  FOREIGN KEY (idRolFk) REFERENCES rol(id)
);
