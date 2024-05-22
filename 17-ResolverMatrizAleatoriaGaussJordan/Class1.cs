using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_6___Parte_2
{
    class Class1
    {
        static void Main(String[] args)
        {
            // Creamos la matriz 7x7 
            double[,] matriz = new double[7, 8];

            // Arreglo para mostrar correctamente los datos de salida
            char[] coeficiente = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', '='};

            int n;

            Console.WriteLine("Este programa resolvera una matriz 7x7 con el metodo de Gauss-Jordan\ncon numeros generados aleatoriamente por la computadora\n");
            // Generamos los numeros dentro de la matriz aleatoriamente
            Random rnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matriz[i, j] = rnd.NextDouble() * 10;
                }
            }

            // Mostraremos la matriz y el valor de cada coeficiente
            Console.Write("  ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(coeficiente[i] + "          ");
            }
            Console.WriteLine("\n");

            // Le mostramos al usuario los numeros que la computadora genero
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(Math.Round(matriz[i, j], 2) + "       ");
                }
                Console.WriteLine();
            }

            // Usaremos ambos for para poder pasar por todos lo valores de la matriz y poder resolverla
            for (int k = 0; k < 7; k++)
            {
                for (int i = k + 1; i < 7; i++)
                {
                    double factor = matriz[i, k] / matriz[k, k];
                    for (int j = k; j < 8; j++)
                    {
                        matriz[i, j] = matriz[i, j] - factor * matriz[k, j];
                    }
                }
            }


            // Verificaremos si la matriz tiene solución, en caso de que si tenga se guardaran las respuestas en la varibale solucion[] para mostrarsela despues al usuario
            double[] solucion = new double[7];
            for (int i = 6; i >= 0; i--)
            {
                double suma = 0;
                for (int j = i + 1; j < 7; j++)
                {
                    suma += matriz[i, j] * solucion[j];
                }
                if (matriz[i, i] == 0)
                {
                    Console.WriteLine("La matriz no tiene solución.");
                    //ReadLine() para que no se me cierre el codigo
                    Console.WriteLine("");
                    n = int.Parse(Console.ReadLine());
                    return;
                }
                solucion[i] = (matriz[i, 7] - suma) / matriz[i, i];
            }

            // Imprimir la solución (Valor de los coeficientes)
            Console.WriteLine("\nLa solución es:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{coeficiente[i]} = {solucion[i]}");
            }
            // ReadLine() para que no se me cierre el codigo
            Console.WriteLine("");
            n = int.Parse(Console.ReadLine());
        }
    } 
}
