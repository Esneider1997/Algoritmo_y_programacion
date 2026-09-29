using System;

public class Helloworld{



    public static void Main(string[] args) {

        Console.WriteLine("1.Saludar");
        Console.WriteLine("2.Mostrar Fecha");
        Console.WriteLine("3.Salir");
        Console.WriteLine("Seleccione una opción: ");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch(opcion){
        case 1:
            Console.WriteLine("¡Hola! Bienvenido!!");
            break;
        case 2:
            Console.WriteLine("La fecha actual es: " + DateTime.Now);
            break;
        case 3:
            Console.WriteLine("¡¡¡Programa Finalizado!!!");
            break;
        default:
            Console.WriteLine("¡Opción no valida!");
            break;
            
        }
    }
}
