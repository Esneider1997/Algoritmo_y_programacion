Algoritmo PagoFacturaAgua
	Definir MontoOriginal, recargo, montoFinal como real;
	Definir DiasRetraso Como Entero;
	
	Escribir "Ingre el monto original de la factura ($ - COD): ";
	Leer MontoOriginal;
	Escribir "ingrese los dias de retraso en el pago: ";
	leer diasRetraso;
	
	montoTotal <- MontoOriginal;
	
	Si diasRetraso > 5 Entonces
		recargo <- MontoOriginal * 0.05;
		montoTotal <- MontoOrginial + recargo;
		Escribir "Se aplicado un recargo del 5% ($",recargo, ") por mora, ";
		
	FinSi
	Escribir "Monto Total definitivo a pagar: $",MontoTotal;
	
FinAlgoritmo
