# Cuarta sección

Desarrolle un método API que permita agregar clientes a una base de datos con la siguiente url: 
http://localhost:6552/controlador/{action}/{id}

Para esta solución se debe utilizar una base de datos SQL server, con la siguiente tabla
```
CREATE TABLE Client (
    Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(255),
    LastName varchar(255),
    DPI varchar(255),
    CreateDate DATETIME
);
```

Y cambiar los datos en las configuraciones (en el archivo appsettings.json, connectionString, connection) con la correspondiente base de datos y servidor

Para consumir el servicio se debe utilizar el metodo POST en la siguiente URL

https://localhost:44390/api/Client

y enviar un objeto JSON con la siguiente estructura:

```
{
    "Name" : "nombre",
    "LastName" : "apellido",
    "DPI" : "numero de dpi"
}
```