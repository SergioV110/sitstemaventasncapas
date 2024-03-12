CREATE DATABASE VENTAS;
GO

CREATE TABLE PERSONA
(
	idpersona INT NOT NULL PRIMARY KEY,
	nombre VARCHAR(50),
	apellido VARCHAR(50),
	telefono INT,
	ci INT,
	correo VARCHAR(100),
	estado VARCHAR(100)
);

CREATE TABLE USUARIO
(
	idusuario INT PRIMARY KEY,
	idpersona INT,
	nombreuser VARCHAR(50),
	contraseña VARCHAR(50),
	fechareg DATE
);

CREATE TABLE USUARIOROL
(
	idusuariorol INT PRIMARY KEY,
	idusuario INT,
	idrol INT,
	fechaasigna DATE,
	estado VARCHAR(50)
);

CREATE TABLE ROL
(
	idrol INT PRIMARY KEY,
	nombre VARCHAR(50),
	estado VARCHAR(50)
);

CREATE TABLE CLIENTE
(
	idcliente INT PRIMARY KEY,
	idpersona INT,
	tipocliente VARCHAR(20),
	codigoclie VARCHAR(20),
	estado VARCHAR(20)
);

CREATE TABLE VENTA
(
	idventa INT PRIMARY KEY,
	idcliente INT,
	idvendedor INT,
	fecha DATE,
	total INT,
	estado VARCHAR(50)
);

CREATE TABLE DETALLEVENT
(
	iddetallevent INT PRIMARY KEY,
	idventa INT,
	idproducto INT,
	cantidad INT,
	precioventa INT,
	subtotal INT,
	estado VARCHAR(50)
);

CREATE TABLE DETALLEING
(
	iddetalleing INT PRIMARY KEY,
	idproducto INT,
	idingreso INT,
	fechavenc DATE,
	cantidad INT,
	preciocosto INT,
	precioventa INT,
	subtotal INT,
	estado VARCHAR(50)
);

CREATE TABLE INGRESO
(
	idingreso INT PRIMARY KEY,
	idproveedor INT,
	fechaingreso DATE,
	total INT,
	estado VARCHAR(50)
);

CREATE TABLE PRODUCTO
(
	idproducto INT PRIMARY KEY,
	idtipoproducto INT,
	nombre VARCHAR(50),
	codigobarra INT,
	idmarca INT,
	unidad INT,
	descripcion VARCHAR(100),
	estado VARCHAR(50)
);

CREATE TABLE PROVEE
(
	idprovee INT PRIMARY KEY,
	idproducto INT,
	idproveedor INT,
	fecha DATE,
	precio INT
);

CREATE TABLE PROVEEDOR
(
	idproveedor INT PRIMARY KEY,
	nombre VARCHAR(50),
	telefono INT,
	direccion VARCHAR(100),
	estado VARCHAR(50)
);

CREATE TABLE TIPOPROD
(
	idtipoprod INT PRIMARY KEY,
	nombre VARCHAR(50),
	estado VARCHAR(50)
);

CREATE TABLE MARCA
(
	idmarca INT PRIMARY KEY,
	nombre VARCHAR(50),
	estado VARCHAR(50)
);

