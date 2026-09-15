Algoritmo alerta_temperatura
	Definir temp Como Real
	
	Escribir "ingrese la temperatura actual en grados celcius (°c):";
	Leer Temp
	
si temp < 0 Entonces
		Escribir "advertencia: temperatura bajo cero detectada. "; 
		Escribir "Riesgto de congelamiento en  carreteras. ",  "conduzca con precaucion.";
		
	FinSi
	 Escribir "Registro meteoroligo completado.";
	
FinAlgoritmo
