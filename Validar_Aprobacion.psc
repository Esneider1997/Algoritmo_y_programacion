Algoritmo ValidarAprobacion 
	Definir nota Como real ; 
	
	Escribir "ingrese la calificacion final obtenida (0.0 - 10.0):";
	leer nota;
	
	si nota >= 3.0 Entonces
		Escribir "¡Enhorabuena! Ha aprobado satisfatoriamente la asignatura.";
	
    SiNo
 	Escribir "Perdiste la asignatura.";
		
	FinSi
	Escribir "Proceso de reporte de calificaciones finalizado.";
FinAlgoritmo
