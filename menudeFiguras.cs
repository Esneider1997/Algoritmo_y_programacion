using System;

class Program
{
    static void Main()
    {
        int opcion = 0;

        do
        {

            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("    MENU DE FIGURAS CON ASTERISCOS    ");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Cuadrado hueco ");
            Console.WriteLine("2. Triangulo rectangulo ");
            Console.WriteLine("3. Piramide centrada ");
            Console.WriteLine("4. Rombo ");
            Console.WriteLine("5. Salir");
            Console.WriteLine("======================================");
            Console.Write("Selecciona una opcion (1-5): ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        DibujarCuadradoHueco(5);
                        break;
                    case 2:
                        DibujarTrianguloInvertido(5);
                        break;
                    case 3:
                        DibujarPiramide(5);
                        break;
                    case 4:
                        DibujarRombo(5);
                        break;
                    case 5:
                        Console.WriteLine("¡Gracias por usar el programa! Hasta luego.");
                        break;
                    default:
                        Console.WriteLine("Opción no valida. Por favor, elige del 1 al 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nEntrada inválida. Ingresa un número entero.");
            }

            if (opcion != 5)
            {
                Console.WriteLine("\nPresiona Enter para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 5);
    }

    static void DibujarCuadradoHueco(int lado)
    {
        Console.WriteLine("--- CUADRADO HUECO  ---");
        
        for (int i = 0; i < lado; i++)
        {
            for (int j = 0; j < lado; j++)
            {

                if (i == 0 || i == lado - 1 || j == 0 || j == lado - 1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }

    static void DibujarTrianguloInvertido(int altura)
    {
        Console.WriteLine("--- TRIANGULO INVERTIDO ---");
        for (int i = altura; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void DibujarPiramide(int altura)
    {
        Console.WriteLine("--- PIRAMIDE CENTRADA ---");
        for (int i = 0; i < altura; i++)
        {
            for (int j = 0; j < altura - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < (2 * i + 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    static void DibujarRombo(int alturaSuperior)
    {
        Console.WriteLine("--- ROMBO ---");

        for (int i = 0; i < alturaSuperior; i++)
        {
            for (int j = 0; j < alturaSuperior - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < (2 * i + 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = alturaSuperior - 2; i >= 0; i--)
        {
            for (int j = 0; j < alturaSuperior - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < (2 * i + 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
