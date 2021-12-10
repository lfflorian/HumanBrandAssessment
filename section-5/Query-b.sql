SELECT productId, count(*) from Detalle
	iNNER JOIN Factura
	ON Factura.Id = Detalle.FacturaId
	GROUP BY Year(Factura.Fecha)