using System;

public class Programa
{
    static void Main(string[] arg)
    {
        
        int contador = 0;
        
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Ingrese el numero" + i + ": ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0) contador++;

        }
        Console.WriteLine("Cantidad de numero positivo es: "+ contador);
    }
}
       
