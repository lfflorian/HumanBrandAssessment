# Segunda sección

Cree un formulario web que permita capturar: Nombre, DPI, Fecha de un usuario, el resultado deberá ser trasladado a una tabla.

Para esta solución se debe utilizar una base de datos SQL server, con la siguiente tabla

```
create table cliente (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Nombre varchar(50),
	DPI varchar(15),
	Fecha DATETIME,
)
```

Y cambiar los datos en las configuraciones (en el archivo web.config, connectionStrings, connection) con la correspondiente base de datos y servidor