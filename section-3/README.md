# Tercera sección

Se deberá crear una función en JavaScript que elimine un cliente específico de la tabla.

Para esta solución se debe utilizar la base de datos anterio de la seccion 2, una base de datos SQL server, con la siguiente tabla para recuperar los elementos a eliminar

```
create table cliente (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Nombre varchar(50),
	DPI varchar(15),
	Fecha DATETIME,
)
```

Y cambiar los datos en las configuraciones (en el archivo web.config, connectionStrings, connection) con la correspondiente base de datos y servidor