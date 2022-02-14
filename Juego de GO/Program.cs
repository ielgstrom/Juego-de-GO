using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_GO
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTabla(5);
        }

        static void PrintTabla(int dimension)
        {
            string[,] tablaInicio = tablaInicial(dimension);
            Console.Write(" ");
            
            for (int k = 0; k < dimension; k++)
            {
                Console.Write(" " + k);
            }
            Console.Write("\n");
            for (int i = 0; i < dimension; i++)
            {
                Console.Write(i);
                for (int j = 0; j < dimension; j++)
                {
                    Console.Write(tablaInicio[i,j]);
                }
                Console.Write("\n");
            }
            
            Console.ReadKey();
        }


        static string[,] tablaInicial(int dimension){
            string[,] tabla0 = new string[dimension, dimension];
            for (int i = 0; i<dimension; i++)
            {
                for (int j = 0; j<dimension; j++)
                {
                    tabla0[i,j]=" o";
                }
            }
            return tabla0;

        }

    }
}
