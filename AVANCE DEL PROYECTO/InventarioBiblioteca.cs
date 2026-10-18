using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVANCE_DEL_PROYECTO
{
    internal class InventarioBiblioteca
    {

        public static void OrdenarYMostrarLibros(List<string> libros)
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("        INVENTARIO DE LIBROS UPN - ORDENADOS     ");
            Console.WriteLine("=================================================");

            if (libros.Count == 0)
            {
                Console.WriteLine("No se registraron libros en la sesión.");
            }
            else
            {
                string[] librosArray = libros.ToArray();

                for (int i = 0; i < librosArray.Length - 1; i++)
                {
                    for (int j = 0; j < librosArray.Length - i - 1; j++)
                    {
                        if (string.Compare(librosArray[j], librosArray[j + 1]) > 0)
                        {
                            string aux = librosArray[j];
                            librosArray[j] = librosArray[j + 1];
                            librosArray[j + 1] = aux;
                        }
                    }
                }

                Console.WriteLine("\nListado final de libros prestados (Ordenados Alfabéticamente):");
                Console.WriteLine("-------------------------------------------------");
                for (int i = 0; i < librosArray.Length; i++)
                {
                    Console.WriteLine($" {i + 1}. {librosArray[i]}");
                }
            }

            Console.WriteLine("=================================================");
            Console.WriteLine("   ¡Avance del proyecto completado con éxito!   ");
            Console.WriteLine("=================================================");
            Console.ReadKey();
        }
    }
}
