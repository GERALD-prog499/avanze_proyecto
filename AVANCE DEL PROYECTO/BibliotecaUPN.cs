using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVANCE_DEL_PROYECTO
{
    internal class BibliotecaUPN
    {
        public static List<string> listaLibros = new List<string>();

        static void Main(string[] args)
        {
            
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("        BIBLIOTECA VIRTUAL - CAMPUS UPN          ");
            Console.WriteLine("=================================================");
            Console.WriteLine("             MÓDULO DE IDENTIFICACIÓN            ");
            Console.WriteLine("=================================================");
            Console.WriteLine();

            int cicloEstudiante = ControlAcademico.modulo_de_identificacion();

           
            int prestamosActivos = 0;
            string respuesta;

            do
            {
                Console.Clear();
                Console.WriteLine("=================================================");
                Console.WriteLine("        SISTEMA DE PRÉSTAMOS - BIBLIOTECA UPN    ");
                Console.WriteLine("=================================================");
                Console.WriteLine("               FICHA DE PRÉSTAMO                 ");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine();

                Console.Write("Ingrese el título del libro: ");
                string tituloLibro = Console.ReadLine();

                Console.Write("Ingrese el tipo de libro (General / Especializado): ");
                string tipoIngresado = Console.ReadLine();

                int diasPrestamo = GestorPrestamos.CalcularDiasPrestamo(cicloEstudiante, tipoIngresado);

                GestorPrestamos.SolicitarPrestamo(ref prestamosActivos);

                listaLibros.Add(tituloLibro);

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($" Libro Solicitado : {tituloLibro}");
                Console.WriteLine($" Días Permitidos  : {diasPrestamo} días");
                Console.WriteLine($" Préstamos Activos: {prestamosActivos} / {GestorPrestamos.max_prestamos}");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("   ¡Préstamo registrado exitosamente!");
                Console.WriteLine("=================================================");

                if (prestamosActivos >= GestorPrestamos.max_prestamos)
                {
                    Console.WriteLine("\nHa alcanzado el límite máximo de préstamos permitidos (5).");
                    Console.ReadKey();
                    break;
                }

                Console.Write("\n¿Desea solicitar otro libro? (S/N): ");
                respuesta = Console.ReadLine().ToUpper();

            } while (respuesta == "S");

      
            InventarioBiblioteca.OrdenarYMostrarLibros(listaLibros);

        }
    }
}

