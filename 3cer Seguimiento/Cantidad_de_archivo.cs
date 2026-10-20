using System;
using System.Xml;

namespace Sistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadarchivos = 0;
            do
            {
                Console.WriteLine("Ingrese la cantidad de archivos a Descargar: ");
                if (!int.TryParse(Console.ReadLine(), out cantidadarchivos)) {
                    cantidadarchivos = 0;
                }

            } while (cantidadarchivos <= 0);

            int archivosDescargados = 0;
            double totalMB = 0;

            for (int i = 1; i <= cantidadarchivos; i++)
            {
                Console.WriteLine($"\nArchivo #{i} - Nombre (Escriba ´Salir´ para detener) :");
                string nombre = Console.ReadLine().Trim();

                if (nombre.ToLower() == "Salir")
                {
                    Console.WriteLine(">>> Proceso de descarga Cancelado!!!");
                    break;
                }
                Console.WriteLine("Tamaño en MB: ");
                double tamanio = 0;

                if (!double.TryParse(Console.ReadLine(), out tamanio) || tamanio <= 0)
                {
                    Console.WriteLine(">>> Tamaño invalido. Archivo omitido");
                    continue;
                }
                Console.WriteLine($">>> Descargando ´{nombre}´({tamanio} MB)... OK");
                archivosDescargados++;
                totalMB += tamanio;
            }
            Console.WriteLine("\n===== RESUMEN DE DESCARGA =========");
            Console.WriteLine($"Archivos Descargados: {archivosDescargados}");
            Console.WriteLine($"Total descargado: {totalMB} MB");
            Console.WriteLine("======================================");
        }
    }
}
