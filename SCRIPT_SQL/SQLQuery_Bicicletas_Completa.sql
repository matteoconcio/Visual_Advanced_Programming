USE MASTER

-- Create the table for bikes
CREATE TABLE Bikes (
    id INT PRIMARY KEY,
    nombre VARCHAR(100),
    Cuadro VARCHAR(100),
    Cadena VARCHAR(100),
    Cierre VARCHAR(100),
    Disco VARCHAR(100),
    Manillar VARCHAR(100),
    Neumaticos VARCHAR(100),
    Rueda VARCHAR(100),
    Pedal VARCHAR(100),
    Plato VARCHAR(100),
    Sillin VARCHAR(100)
);
-- Add new columns unidades and precio to the Bikes table
ALTER TABLE Bikes
ADD unidades INT,
    precio DECIMAL(10, 2);


INSERT INTO Bikes (id, nombre, Cuadro, Cadena, Cierre, Disco, Manillar, Neumaticos, Rueda, Pedal, Plato, Sillin)
VALUES 
-- Bicycle 1: City Cruiser
(01, 'City Cruiser', 'Cuadro Elops Speed', 'Cadena KMC 104 pasos', 'Cierre rapido', 'Disco Galfer 160x1.8MM', 'Manillar de ciudad', 'Cubierta Michelin Country', 'Rueda Bonin', 'Pedales Carretera', 'Plato 6 velocidades', 'Sillin DPV Apolo'),
-- Bicycle 2: Mountain Bike
(02, 'BMX', 'Cuadro BMX Silencer', 'Cadena KMC 112 pasos', 'Cierre diagonal', 'Disco Galfer 140x1.8MM', 'Manillar recto', 'Cubierta Pirelli', 'Rueda Swiss', 'Pedales BMX', 'Plato 8 velocidades', 'Sillin Titan Nack'),
-- Bicycle 3: Road Bike
(03, 'Mountain Bike', 'Cuadro Triban BTWIN', 'Cadena KMC 116 pasos', 'Cierre diagonal', 'Disco Galfer 180x1.8MM', 'Manillar de carrera', 'Cubierta Vittoria Corsa', 'Rueda Shimano', 'Pedales BTT', 'Plato 7 velocidades', 'Sillin Selle SMP');
