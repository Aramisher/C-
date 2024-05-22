using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_6___Parte_1
{
	class Class1
	{
		static void Main(String[] args)
		{

            int n;

            // Esta variable nos servira para mostrarle al usuario que dato esta introduciendo
            char[] coeficiente = { 'A', 'B', 'C', 'D', 'R' };

            // Creamos la matriz que usaremos en el problema
            double[,] matriz = new double[4, 5];

            Console.WriteLine("Este programa te resolvera una matriz 4x4 con el metodo de Gauss Jordan, \na continuación se te pediran todos los valores dentro de la matriz\n");

            //Le pediremos todos los valores necesarios al usuario
            Console.WriteLine("Ingrese los valores del sistema lineal de 4 ecuaciones con 4 incógnitas:\nAviso R = Respuesta\n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Ecuación {i + 1} Coeficiente de {coeficiente[j]}: ");
                    matriz[i, j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            // Imprimir la matriz original
            Console.WriteLine("Matriz original:");
            imprimirMatriz(matriz);

            // Usaremos ambos for para poder pasar por todos lo valores de la matriz y poder resolverla
            for (int k = 0; k < 4; k++)
            {
                for (int i = k + 1; i < 4; i++)
                {
                    double factor = matriz[i, k] / matriz[k, k];
                    for (int j = k; j < 5; j++)
                    {
                        matriz[i, j] = matriz[i, j] - factor * matriz[k, j];
                    }
                }
            }

            // Imprimir la matriz ya resuelta
            Console.WriteLine("Matriz resuelta:");
            imprimirMatriz(matriz);

            // Verificaremos si la matriz tiene solución, en caso de que si tenga se guardaran las respuestas en la varibale solucion[] para mostrarsela despues al usuario
            double[] solucion = new double[4];
            for (int i = 3; i >= 0; i--)
            {
                double suma = 0;
                for (int j = i + 1; j < 4; j++)
                {
                    suma += matriz[i, j] * solucion[j];
                }
                if (matriz[i, i] == 0)
                {
                    Console.WriteLine("La matriz no tiene solución.");
                    //Console.ReadLine() para que no se me cierre el codigo
                    Console.WriteLine("");
                    n = int.Parse(Console.ReadLine());
                    return;
                }
                solucion[i] = (matriz[i, 4] - suma) / matriz[i, i];
            }

            // Imprimir la solución (Valor de los coeficientes)
            Console.WriteLine("La solución del sistema lineal es:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{coeficiente[i]} = {solucion[i]}");
            }
            // ReadLine() para que no se me cierre el codigo
            Console.WriteLine("");
            n = int.Parse(Console.ReadLine());
        }


        // Método para imprimir la matriz, lo hice un metodo ya que lo uso 2 veces para imprimir la matriz original y la resuelta
        static void imprimirMatriz(double[,] matriz)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
	
