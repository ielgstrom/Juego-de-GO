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
            int dimension = 10;
            string[,] tablero = tablaInicial(dimension);
            for (int i=0; i<5; i++)
            {
                Console.ForegroundColor= ConsoleColor.White;
            PrintTabla(tablero);
            EscojerPosicion(tablero);
            PosicionAleatoriaJugador(tablero);

            }
        }

        public static void PrintTabla(string[,] tablaMomentanea)
        {
            Console.Clear();
            Console.Write(" ");

            for (int k = 0; k < tablaMomentanea.GetLength(0); k++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" " + k);
            }
            Console.Write("\n");
            for (int i = 0; i < tablaMomentanea.GetLength(0); i++)
            {
                Console.Write(i);
                for (int j = 0; j < tablaMomentanea.GetLength(0); j++)
                {
                    if (tablaMomentanea[i, j]==" A")
                        Console.ForegroundColor = ConsoleColor.Green;
                    else if (tablaMomentanea[i, j] == " B")
                        Console.ForegroundColor = ConsoleColor.Red;
                    else Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(tablaMomentanea[i, j]);
                }
                Console.Write("\n");
            }
        }


        public static string[,] tablaInicial(int dimension) {
            string[,] tabla0 = new string[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    tabla0[i, j] = " o";
                }
            }
            return tabla0;

        }

        public static string[,] EscojerPosicion(string[,] tablaPrecedente)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ahora es tu turno, has de escojer una posicion para la casilla X y la Y");
            Console.WriteLine("\nEscoje un valor entre 0 y " + (tablaPrecedente.GetLength(0) - 1) + " para el eje X");
            int ValorInputX = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEscoje un valor entre 0 y " + (tablaPrecedente.GetLength(0) - 1) + " para el eje Y");
            int ValorInputY = int.Parse(Console.ReadLine());
            if  (ValorInputX > (tablaPrecedente.GetLength(0) - 1) && ValorInputY > (tablaPrecedente.GetLength(0) - 1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Te has ido de los parametros del juego");
                EscojerPosicion(tablaPrecedente);
            }
            if (tablaPrecedente[ValorInputY, ValorInputX] == " o")
                tablaPrecedente[ValorInputY, ValorInputX] = " A";
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Esta posicion ya esta ocupada, escoje otro lugar");
                EscojerPosicion(tablaPrecedente);
            }
            return tablaPrecedente;

        }
        public static string[,] PosicionAleatoriaJugador(string[,] tablaPrecedente)
        {
            Random rnd = new Random();
            int randomX = rnd.Next(0, tablaPrecedente.GetLength(0) - 1);
            int randomY = rnd.Next(0, tablaPrecedente.GetLength(0) - 1);
            if (tablaPrecedente[randomY, randomX] == " o")
                tablaPrecedente[randomY, randomX] = " B";
            else PosicionAleatoriaJugador(tablaPrecedente);
            Console.WriteLine("El jugador opuesto ha puesto la ficha en (" + randomY + "," + randomX + ")");
            Console.ReadKey();

            return tablaPrecedente;
        }
    }
}
