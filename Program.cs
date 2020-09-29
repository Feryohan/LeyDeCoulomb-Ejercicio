using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeyDeCoulomb
{
    class Program
    {
        static void Main(string[] args)
        {
            double carga1;
            double carga2;
            double radio;
            double distancia;

            Console.WriteLine("    >>>Programa de Ley de Coulomb<<<     \n\n");

            #region Datos
            //Se leen los datos del usuario
            Console.WriteLine("¿\n Cuál es el valor de la carga 1 [microC]? \n");
            carga1 = byte.Parse(Console.ReadLine());

            Console.WriteLine("¿\n Cuál es el valor de la carga 2? [microC]\n");
            carga2 = byte.Parse(Console.ReadLine());


            Console.WriteLine("¿\n Cuál es la distancia entre la carga 1 y la carga 2? [mm]\n");
            radio = byte.Parse(Console.ReadLine());
            #endregion

            distancia = radio/Math.Sqrt(carga1);

        }
    }
}
