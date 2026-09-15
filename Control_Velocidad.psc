Algoritmo ControlVelocidad
	Definir velocidad Como Real ;
	
	Escribir " ingrese la velocidad registrada del vehiculo (km/h) :";
	Leer  velocidad
	
	Si velocidad >80 Entonces
		Escribir  "¡ALERTA! Ha superado el limite de velocidad de 80 km/h. ";
		Escribir "se ha generado una formula automaticamente .";
		
	FinSi
	
	Escribir "evaluacion de transito finalizada .";
	
FinAlgoritmo
