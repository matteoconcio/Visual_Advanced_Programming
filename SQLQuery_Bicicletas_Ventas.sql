USE master

---- new table Ventas
CREATE TABLE Ventas (
    VentaID INT IDENTITY(1,1) PRIMARY KEY,
    FechaVenta DATETIME,
    Cliente VARCHAR(100)
);

---- new table DetalleVentas
CREATE TABLE DetallesVenta (
    DetalleID INT PRIMARY KEY,
    VentaID INT,
    Producto VARCHAR(100),
    Precio DECIMAL(10, 2),
    Cantidad INT,
    FOREIGN KEY (VentaID) REFERENCES Ventas(VentaID)
);