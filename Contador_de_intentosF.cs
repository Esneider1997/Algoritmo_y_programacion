using System;

public class helloworld {
    public static void Main(String[] args) {

        const string claveCorrecto = "ELPEPE";
        string clave;
        int intentosFallido = 0;

        do
        {
            Console.WriteLine("Ingrese la Contraseña");
            clave = Console.ReadLine();
            if (clave != claveCorrecto)
            {
                intentosFallido++;
                Console.WriteLine("Contraseña incorrecta, intentalo de nuevo.");
            }

        } while (clave != claveCorrecto);
        Console.WriteLine($"\n Acceso concedido");
        Console.WriteLine($"intentos fallido: {intentosFallido}");
    }
}
