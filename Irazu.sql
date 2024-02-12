CREATE DATABASE Irazu
GO
Use Irazu
go
create table Roles(
	Id_Rol int IDENTITY(1,1) primary key,
	Nombre_Rol varchar(25),
	Descripcion varchar(100),
);
CREATE TABLE Permisos(
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	Modulo VARCHAR(20) NOT NULL,
    Accion VARCHAR(27) NULL,
    Id_Rol INT NOT NULL,
	CONSTRAINT Fk_PERMISOS_ROLES FOREIGN KEY(Id_Rol) REFERENCES Roles(Id_Rol)
);
CREATE TABLE Usuarios(
	ID_Usuario INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Cedula VARCHAR(25) NOT NULL UNIQUE,
	Nombre VARCHAR(25) NOT NULL,
	Primer_Apellido VARCHAR(25) NOT NULL,
	Segundo_Apellido VARCHAR(25) NOT NULL,
	Nombre_Usuario VARCHAR(25) NOT NULL,
	Genero INT NOT NULL,
	Id_Rol int NOT NULL,
	Contrasena VARCHAR(MAX) NOT NULL,
	Estado INT NOT NULL,
	Telefono INT NULL,
	Correo VARCHAR(30) NOT NULL,
	CONSTRAINT Fk_USUARIOS_ROLES FOREIGN KEY(Id_Rol) REFERENCES Roles(Id_Rol),
);

CREATE TABLE UsuarioCentroDiurno(
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Expediente VARCHAR(25) NOT NULL,
	Cedula VARCHAR(25) NOT NULL UNIQUE,
	Nombre VARCHAR(25) NOT NULL,
	PrimerApellido VARCHAR(25) NOT NULL,
	SegundoApellido VARCHAR(25) NOT NULL,
	Genero VARCHAR(2) NOT NULL,
	Familiardirecto VARCHAR(MAX) NOT NULL,
	Lugarvivienda VARCHAR(MAX) NOT NULL,
	Padecimientos VARCHAR(MAX) NOT NULL,
	Medicamentos VARCHAR(MAX) NOT NULL,
	Estado BIT,
	Telefono VARCHAR(8) NOT NULL,
);
CREATE TABLE Puestos(
	Id_Puesto INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Nombre VARCHAR(25)NOT NULL,
	Descripcion varchar(100)NULL,
	Salario DECIMAL NOT NULL
);
CREATE TABLE Personal(
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Cedula VARCHAR(25) NOT NULL UNIQUE,
	Nombre VARCHAR(25) NOT NULL,
	Primer_Apellido VARCHAR(25) NOT NULL,
	Segundo_Apellido VARCHAR(25) NOT NULL,
	Genero INT NOT NULL,
	Estado INT NOT NULL,
	Telefono INT NULL,
	Direccion VARCHAR(MAX) NOT NULL,
	Id_Puesto INT NOT NULL,
	CONSTRAINT Fk_PERSONAL_PUESTOS FOREIGN KEY(Id_Puesto) REFERENCES Puestos(Id_Puesto),
);
CREATE TABLE Tipo_Medicamentos(
	ID_Tipo_Medicamento INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Nombre VARCHAR(25)NOT NULL,
	Descripcion varchar(100)NULL
);
CREATE TABLE Medicamentos(
	ID_Medicamento INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Nombre VARCHAR(25)NOT NULL,
	Presentacion VARCHAR(100)NULL,
	ID_Tipo_Medicamento INT NOT NULL,
	Concentracion DECIMAL NOT NULL,
	Cantidad INT NOT NULL,
	CONSTRAINT Fk_PRODUCTOS_TIPO FOREIGN KEY(ID_Tipo_Medicamento) REFERENCES Tipo_Medicamentos(ID_Tipo_Medicamento),
);

CREATE TABLE Bitacora_Sesiones(
    codigo_ingreso_salida int IDENTITY(1,1) primary key, 
    fecha_hora_ingreso DATETIME NOT NULL,
    fecha_hora_salida DATETIME NULL,
    Id_Usuario INT,
	CONSTRAINT Fk_SESIONES_USUARIOS FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario)
);

CREATE TABLE Bitacora_Movimientos(
   codigo_movimiento_usuario int IDENTITY(1,1) primary key, 
   fecha_hora_movimiento DATETIME NOT NULL,
   tipo_movimiento varchar(50),
   modulo VARCHAR(20),
   Id_Usuario INT,
   CONSTRAINT Fk_MOVIMIENTOS_USUARIOS FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario)
);

INSERT INTO Roles(Nombre_Rol,Descripcion)VALUES('Administrador','Administrador')

INSERT INTO Permisos (Modulo, Accion, Id_Rol) VALUES
('Roles', 'Roles', 1),
('Roles', 'Agregar', 1),
('Roles', 'Modificar', 1),
('Roles', 'Eliminar', 1),
('Roles', 'Consultar', 1),
('Usuarios', 'Usuarios', 1),
('Usuarios', 'Agregar', 1),
('Usuarios', 'Modificar', 1),
('Usuarios', 'Eliminar', 1),
('Usuarios', 'Consultar', 1),
('Clientes', 'Clientes', 1),
('Clientes', 'Agregar', 1),
('Clientes', 'Modificar', 1),
('Clientes', 'Eliminar', 1),
('Clientes', 'Consultar', 1),
('Productos', 'Estudiantes', 1),
('Productos', 'Agregar', 1),
('Productos', 'Modificar', 1),
('Productos', 'Eliminar', 1),
('Productos', 'Consultar', 1)

INSERT INTO Usuarios (Cedula,Nombre,Primer_Apellido,Segundo_Apellido, Nombre_Usuario, Contrasena,Telefono,Correo,Genero,Id_Rol, Estado)
VALUES ('123456789', 'Usuario','Usuario','Usuario', 'Administrador1', 'HVEvEz0I1wRgOshEmHhas82xZwI=',12345678,'1@1.com', 1,1,1)