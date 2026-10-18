using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVANCE_DEL_PROYECTO
{
    public class GestorPrestamos
    {
        public static int max_prestamos = 5;

        // Función con retorno
        public static int CalcularDiasPrestamo(int ciclo, string tipoLibro)
        {
            int dias = 0;
            if (ciclo >= 5 || tipoLibro.ToLower() == "general")
            {
                dias = 7;
            }
            else
            {
                dias = 3;
            }

            return dias;
        }

        public static void SolicitarPrestamo(ref int prestamosActivos)
        {
            prestamosActivos++;
        }
    }
}

