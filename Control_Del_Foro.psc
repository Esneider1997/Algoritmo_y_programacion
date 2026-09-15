Algoritmo ControlDeForo
	Definir asistentes, exceso Como Entero
	Escribir "Ingrese la cantidad de asistencia confirmados.";
	leer asistentes
	
	Si asistentes > 150 Entonces
		exceso = asistentes - 150;
		Escribir "¡ALERTA DE SEGURIDAD! se ha excedido la capacidad maxima de la sala. ";
		Escribir "Hay", exceso "Persona(s) por encima de limite permitido. "; 
		
	FinSi
	
	Escribir "Registro de aforo concluido. ";
	
FinAlgoritmo
