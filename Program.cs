using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeyDeCoulomb
{
    class Program
    {
        static void Main()
        {
            #region Datos
            //Variables ingresadas por el usuario
            double carga1;
            double carga2;
            double radio;

            //Constantes
            double k = 9e9; //e es notación cientifica
            double carga3 = 1e-6; //es una carga puntual 

            //Resultados
            double distancia1;
            double distancia2;
            double fuerza1a;
            double fuerza1b;
            double fuerza2a;
            double fuerza2b;
            #endregion

            #region Lectura de datos

            Console.WriteLine("    >>>Programa de Ley de Coulomb<<<     \n\n");

            //Se leen los datos del usuario
            Console.WriteLine("\n ¿Cuál es el valor de la carga 1 [microC]?: ");
            carga1 = int.Parse(Console.ReadLine())*1e-6;

            Console.WriteLine("\n ¿Cuál es el valor de la carga 2? [microC]: ");
            carga2 = int.Parse(Console.ReadLine())*1e-6;

            Console.WriteLine("\n ¿Cuál es la distancia entre la carga 1 y la carga 2? [mm]: ");
            radio = int.Parse(Console.ReadLine())*1e-3;
            #endregion

            #region Cálculo de distancias
            distancia1 = radio / (Math.Sqrt(carga1 / carga2) - 1);
            distancia2 = radio / (-Math.Sqrt(carga1 / carga2) - 1);

            Console.WriteLine("\nLas distancias calculadas son: \nDistancia 1: "+Math.Round(distancia1,4)+" [m]\nDistancia 2: "+Math.Round(distancia2,4)+" [m]");
            #endregion

            #region Cálculo de fuerzas para distancia 1 y 2

            fuerza1a = -(k * carga1 * carga3) / (Math.Pow((radio+distancia1),2));
            fuerza1b = (k * carga2 * carga3) / (Math.Pow(distancia1, 2));

            fuerza2a = (k * carga1 * carga3) / (Math.Pow((radio + distancia2), 2));
            fuerza2b = (k * carga2 * carga3) / (Math.Pow(distancia2, 2));

            Console.WriteLine("\n>>>Distancia 1<<<\n Fuerza con la carga 1: "+ Math.Round(fuerza1a, 4)+" [N]\n Fuerza con la carga 2: "+ Math.Round(fuerza1b, 4)+" [N]");
            double sum1 = fuerza1a + fuerza1b;
            Console.WriteLine("\nSuma de fuerzas: " + Math.Round(sum1,3) +" [N]");

            Console.WriteLine("\n>>>Distancia 2<<<\n Fuerza con la carga 1: " + Math.Round(fuerza2a, 4) +" [N]\n Fuerza con la carga 2: " + Math.Round(fuerza2b, 4)+" [N]");
            double sum2 = fuerza2a + fuerza2b;
            Console.WriteLine("\nSuma de fuerzas: " + Math.Round(sum2,3)+" [N]");
            #endregion

            Console.ReadLine();
        }
    }
}
