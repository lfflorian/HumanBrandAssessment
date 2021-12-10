SELECT Factura.Total FROM Factura  
	INNER JOIN Cliente
	ON Factura.IdCliente = Cliente.Id
	WHERE Cliente.Id = --PARAMETRO
	GROUP BY YEAR(Fecha), MONTH(Fecha), Tipo_Moneda