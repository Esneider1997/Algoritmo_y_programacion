using System;
using System.Xml;

namespace Sistema
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double espacioDisponible = 0;
            do
            {
                Console.WriteLine("Ingrese el espacio disponible en disco (MB): ");
                if (!double.TryParse(Console.ReadLine(), out espacioDisponible) || espacioDisponible <= 0)
                {
                    Console.WriteLine(">>> Espacio inválido. Debe ser mayor a 0.");
                    espacioDisponible = 0;
                }
            } while (espacioDisponible <= 0);

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

                if (nombre.ToLower() == "salir")
                {
                    Console.WriteLine(">>> Proceso de descarga Cancelado!!!");
                    break;
                }

                if (string.IsNullOrEmpty(nombre) || nombre.Length > 20)
                {
                    Console.WriteLine(">> Nombre de archivo inválido. Omitido.");
                    continue;
                }

                Console.WriteLine("Tamaño en MB: ");
                double tamanio = 0;

                if (!double.TryParse(Console.ReadLine(), out tamanio) || tamanio <= 0)
                {
                    Console.WriteLine(">>> Tamaño invalido. Archivo omitido");
                    continue;
                }

                if (tamanio > espacioDisponible)
                {
                    Console.WriteLine(">> Espacio insuficiente en disco. Descarga detenida.");
                    break;
                }

                espacioDisponible -= tamanio;

                string categoria = "";
                if (tamanio < 1)
                {
                    categoria = "Pequeño";
                }
                else if (tamanio <= 10)
                {
                    categoria = "Mediano";
                }
                else
                {
                    categoria = "Grande";
                }

                Console.WriteLine($">>> Descargando ´{nombre}´({tamanio} MB) - Categoría: {categoria}... OK");
                archivosDescargados++;
                totalMB += tamanio;
            }

            Console.WriteLine("\n===== RESUMEN DE DESCARGA =========");
            Console.WriteLine($"Archivos Descargados: {archivosDescargados}");
            Console.WriteLine($"Total descargado: {totalMB} MB");
            Console.WriteLine($"Espacio restante en disco: {espacioDisponible} MB");
            Console.WriteLine("======================================");
        }
    }
}
