CREATE DATABASE HoyNoCircula;
GO
USE HoyNoCircula;
GO

--  Creación de tablas vehiculos
CREATE TABLE vehiculos (
    id BIGINT IDENTITY(1,1) PRIMARY KEY,
    placa VARCHAR(10) NOT NULL UNIQUE,
    marca VARCHAR(50) NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    color VARCHAR(30),
    chasis VARCHAR(50),
    anio INT,
    fecha_registro DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- Creación de tabla consultas
CREATE TABLE consultas (
    id BIGINT IDENTITY(1,1) PRIMARY KEY,
    placa VARCHAR(10) NOT NULL,
    fecha_consulta DATETIME NOT NULL,
    puede_circular BIT NOT NULL,
    mensaje VARCHAR(150),
    fecha_creacion DATETIME DEFAULT GETDATE()
);
GO


--- Select de vehiculos registrados
select * from vehiculos

--- Select de consulta de vehiculos
select * from consultas