-- Crear tabla para piezas de tipo Cuadro
CREATE TABLE Cuadro (
    id INT,
    nombre VARCHAR(100),
    unidades INT,
    precio DECIMAL(10, 2)
);

-- Insertar datos de tipo Cuadro
INSERT INTO Cuadro (id, nombre, unidades, precio)
SELECT id, nombre, unidades, precio
FROM piezas
WHERE tipo = 'Cuadro';

-- Crear tabla para piezas de tipo Cadena
CREATE TABLE Cadena (
    id INT,
    nombre VARCHAR(100),
    unidades INT,
    precio DECIMAL(10, 2)
);

-- Insertar datos de tipo Cadena
INSERT INTO Cadena (id, nombre, unidades, precio)
SELECT id, nombre, unidades, precio
FROM piezas
WHERE tipo = 'Cadena';

-- Crear tabla para piezas de tipo Cierre
CREATE TABLE Cierre (
    id INT,
    nombre VARCHAR(100),
    unidades INT,
    precio DECIMAL(10, 2)
);

-- Insertar datos de tipo Cierre
INSERT INTO Cierre (id, nombre, unidades, precio)
SELECT id, nombre, unidades, precio
FROM piezas
WHERE tipo = 'Cierre';

-- Crear tabla para piezas de tipo Disco
CREATE TABLE Disco (
    id INT,
    nombre VARCHAR(100),
    unidades INT,
    precio DECIMAL(10, 2)
);

-- Insertar datos de tipo Disco
INSERT INTO Disco (id, nombre, unidades, precio)
SELECT id, nombre, unidades, precio
FROM piezas
WHERE tipo = 'Disco';

-- Crear tabla para piezas de tipo Manillar
CREATE TABLE Manillar (
    id INT,
    nombre VARCHAR(100),
    unidades INT,
    precio DECIMAL(10, 2)
);

-- Insertar datos de tipo Manillar
INSERT INTO Manillar (id, nombre, unidades, precio)
SELECT id, nombre, unidades, precio
FROM piezas
WHERE tipo = 'Manillar';

-- Crear tabla para piezas de tipo Neumaticos
CREATE TABLE Neumaticos (
    id INT,
    nombre VARCHAR(100),
    unidades INT,
    precio DECIMAL(10, 2)
);

-- Insertar datos de tipo Neumaticos
INSERT INTO Neumaticos (id, nombre, unidades, precio)
SELECT id, nombre, unidades, precio
FROM piezas
WHERE tipo = 'Neumaticos';

-- Crear tabla para piezas de tipo Rueda
CREATE TABLE Rueda (
    id INT,
    nombre VARCHAR(100),
    unidades INT,
    precio DECIMAL(10, 2)
);

-- Insertar datos de tipo Rueda
INSERT INTO Rueda (id, nombre, unidades, precio)
SELECT id, nombre, unidades, precio
FROM piezas
WHERE tipo = 'Rueda';

-- Crear tabla para piezas de tipo Pedal
CREATE TABLE Pedal (
    id INT,
    nombre VARCHAR(100),
    unidades INT,
    precio DECIMAL(10, 2)
);

-- Insertar datos de tipo Pedal
INSERT INTO Pedal (id, nombre, unidades, precio)
SELECT id, nombre, unidades, precio
FROM piezas
WHERE tipo = 'Pedal';

-- Crear tabla para piezas de tipo Plato
CREATE TABLE Plato (
    id INT,
    nombre VARCHAR(100),
    unidades INT,
    precio DECIMAL(10, 2)
);

-- Insertar datos de tipo Plato
INSERT INTO Plato (id, nombre, unidades, precio)
SELECT id, nombre, unidades, precio
FROM piezas
WHERE tipo = 'Plato';

-- Crear tabla para piezas de tipo Sillin
CREATE TABLE Sillin (
    id INT,
    nombre VARCHAR(100),
    unidades INT,
    precio DECIMAL(10, 2)
);

-- Insertar datos de tipo Sillin
INSERT INTO Sillin (id, nombre, unidades, precio)
SELECT id, nombre, unidades, precio
FROM piezas
WHERE tipo = 'Sillin';
