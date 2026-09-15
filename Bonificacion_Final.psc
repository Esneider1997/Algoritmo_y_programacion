Algoritmo BonificacionFinal
	Definir UnidadesVendidas, antiguedad Como Entero
	Definir SueldoBase, Bonificacion, sueldofinal Como Real
	
	sueldoBase = 520000
	bonificacion = 500000
	SueldoFinal = sueldobase

	Escribir "Ingrese la cantidad de unidades vendidas en el mes: ";
	Leer unidadesvendidas;
	Escribir "ingrese los años antiguedad en la empresa: ";
	leer antiguedad;
	
	si unidadesvendidas > 50 Y antiguedad > 2 Entonces
		sueldofinal <- sueldobase + bonificacion;
		Escribir "¡Felicidades! Has complido con las metas de ventas, tienes una bonificacion de: ", bonificacion ;
	FinSi
	Escribir "Tu salario este mes es de: $", sueldofinal;
	
FinAlgoritmo
