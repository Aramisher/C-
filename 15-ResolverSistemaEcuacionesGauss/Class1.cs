using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
	class Class1
	{
        static void Main(string[] args)
        {
            // Variable para que no se me cierre el programa
            int f;

            // Renglones que tendra la matriz
            int n;

            Console.WriteLine("Programa que analiza una matriz y determina si no se\npuede resolver o si tiene una cantidad infinita de soluciones\n");
            Console.WriteLine("Este programa te pedira que pongas el tamaño de una\nmatriz, en caso de poner 2 la matriz será 2x2\n");

            // Le pedimos al usuario el tamaño de la matriz
            Console.Write("Ingrese el número de renglones de la matriz: ");
            n = int.Parse(Console.ReadLine());

            double[,] matriz = new double[n, n + 1]; // Creamos matriz

            // Preguntar los valores de la matriz al usuario
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n+1; j++)
                {
                    Console.Write($"Fila {i + 1}, Columna {j + 1}: ");
                    matriz[i, j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            // Aplicar el método de Gauss
            for (int i = 0; i < n; i++)
            {
                // Buscamos el pivote
                double pivote = matriz[i, i];
                if (pivote == 0)
                {
                    // Verificamos si todos los demás elementos del renglón son cero
                    bool todosCeros = true;
                    for (int j = i + 1; j < n + 1; j++)
                    {
                        if (matriz[i, j] != 0)
                        {
                            todosCeros = false;
                            break;
                        }
                    }
                    if (todosCeros) // Si todos los elementos del renglon son 0 no hay solución
                    {
                        Console.WriteLine("Matriz sin solución");
                        // ReadLine() Para que no se me cierre el programa
                        Console.Write("");
                        f = int.Parse(Console.ReadLine());
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Matriz con una cantidad infinita de soluciones");
                        //ReadLine() Para que no se me cierre el programa
                        Console.Write("");
                        f = int.Parse(Console.ReadLine());
                        return;
                    }
                }

                // Hacer ceros en la columna abajo del pivote
                for (int j = i + 1; j < n; j++)
                {
                    double factor = matriz[j, i] / pivote;
                    for (int k = i; k < n + 1; k++)
                    {
                        matriz[j, k] = matriz[j, k] - factor * matriz[i, k];
                    }
                }
            }

            // Resolvemos la matriz
            double[] solucion = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double suma = 0;
                for (int j = i + 1; j < n; j++)
                {
                    suma += matriz[i, j] * solucion[j];
                }
                solucion[i] = (matriz[i, n] - suma) / matriz[i, i];
            }

            // Mostramos la solución al usuario
            Console.WriteLine("La solución del sistema es:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"x{i + 1} = {solucion[i]}");
            }

        }
    }
}
