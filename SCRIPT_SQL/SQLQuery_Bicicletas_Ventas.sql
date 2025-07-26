USE master

---- new table Ventas
CREATE TABLE Ventas (
    VentaID INT IDENTITY(1,1) PRIMARY KEY,
    FechaVenta DATETIME,
    Cliente VARCHAR(100)
);

