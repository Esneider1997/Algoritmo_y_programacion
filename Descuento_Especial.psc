Algoritmo DescuentoEspecial
	Definir Montocompra,descuento,montofinal como real;
	
	Escribir "ingrese el valor total de su compra ($) :";
	Leer montocompra;
	
	montofinal <- montoCompra;
	
	si montoCompra > 500 Entonces
		descuento <- montocompra * 0.50;
		montofinal <- montocompra - descuento;
		Escribir "¡Felicidades Ha recibido un descuento de: $", descuento;
		
	FinSi
	
	Escribir "el total a pagar es: $", montofinal;
FinAlgoritmo
