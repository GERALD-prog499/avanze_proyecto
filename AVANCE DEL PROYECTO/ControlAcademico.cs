using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVANCE_DEL_PROYECTO
{
    internal class ControlAcademico
    {
        public static int modulo_de_identificacion()
        {
            Console.WriteLine("Por favor, ingrese sus datos de acceso:");
            Console.WriteLine("-------------------------------------------------");

            Console.Write("INGRESE SU CODIGO DE ESTUDIANTE: N");
            int codigo_estudiante;
            string entrada;
            while (!int.TryParse(entrada = Console.ReadLine(), out codigo_estudiante) || entrada.Length != 8)
            {
                Console.WriteLine("Error: El código debe tener EXACTAMENTE 8 dígitos");
                Console.Write("INGRESE SU CODIGO DE ESTUDIANTE: N");
            }

            Console.Write("INGRESE SU CICLO: ");
            int ciclo_estudiante;
            while (!int.TryParse(Console.ReadLine(), out ciclo_estudiante) || ciclo_estudiante < 1 || ciclo_estudiante > 10)
            {
                Console.WriteLine("Error: El ciclo debe ser un número entre 1 y 10.");
                Console.Write("INGRESE SU CICLO: ");
            }

            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("   ¡Acceso concedido! Bienvenido a la red UPN.   ");
            Console.WriteLine("=================================================");
            Console.ReadKey();

            return ciclo_estudiante;                                                                      //


        } 
    }
}
