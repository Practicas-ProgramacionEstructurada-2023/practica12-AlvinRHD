using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglo bidimensional
            int[,] matrizBidimensional = new int[3, 4];

            //Inicializacion del arreglo bidimensional
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    matrizBidimensional[fila, columna] = fila * 4 + columna + 1;
                }
            }

            //Imprimir el arreglo bidimensional
            Console.WriteLine("\nArreglo Bidimensional");
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    Console.WriteLine(matrizBidimensional[fila, columna] + "\t");
                }
                Console.WriteLine();
            }//ARREGLO BIDIMENSIONAL

            //Arreglo tridimensional
            int[,,] matrizTridimensional = new int[3, 3, 4];

            //Inicializacion del arreglo tridimensional
            for (int cubo = 0; cubo < 3; cubo++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    for (int columna = 0; columna < 4; columna++)
                    {
                        matrizTridimensional[cubo, fila, columna] = cubo * 12 + fila * 4 + columna + 1;
                    }
                }
            }

            //Imprimir el arreglo tridimensional
            Console.WriteLine("\nArreglo Tridimensional");
            for (int cubo = 0; cubo < 3; cubo++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    for (int columna = 0; columna < 4; columna++)
                    {
                        Console.WriteLine(matrizTridimensional[cubo, fila, columna] + "\t");
                    }
                    Console.WriteLine();
                }
            }//FIN DE ARREGLO TRIDIMENSIONAL
        }
    }
}
