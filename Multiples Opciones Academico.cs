using System;

public class Helloworld{



    public static void Main(string[] args) {

        Console.WriteLine("1.Nombre");
        Console.WriteLine("2.Edad");
        Console.WriteLine("3.Genero");
        Console.WriteLine("4.Facultad");
        Console.WriteLine("5.Programa academico");
        Console.WriteLine("Seleccione una opción: ");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch(opcion){
        case 1:
            Console.WriteLine("ingrese su nombre");
                string name = Console.ReadLine();
                Console.WriteLine("ingrese su edad");
                int age =int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese su genero F/M");
                string gender = Console.ReadLine();
                Console.WriteLine("ingrese facultad");
                string faculty = Console.ReadLine();
                Console.WriteLine("ingrese programa academico");
                string progam = Console.ReadLine();
                

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
