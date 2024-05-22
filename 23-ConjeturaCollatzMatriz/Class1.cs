using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidencia_1
{
	class Class1
	{
		static void Main(String[] args)
		{
			// Matriz que le pediremos al usuario
			double[,] matriz;

			// Con estas variables determinaremos el tamaño de la matriz
			int fila = 0, columna = 0;

			// Nos servira para saber cuantos pasos tomo para que el numero llegue a 1
			int contador;

			// Le explicamos al usuario que hace el programa, los valores de entrada que se le solicitaran y los limites de los valores de entrada
			Console.WriteLine("Este programa te pedirá la cantidad de valores de una matriz y hará la conjetura de\nCollatz hasta y te dira cuantos paso hizo cada valor de la matriz para llegar a 1\n");

			Console.WriteLine("AVISO: Los valores de las dimensiones de la matriz solo pueden ser numeros enteros del 1 al 10\n");
			Console.WriteLine("Pon el tamaño de la matriz(x, y): \n");

			// Ambos do nos servirán para pedirle al usuario un numero entre 1 y 10 en caso de que ponga un numero fuera del rango se le pedirá nuevamente
			do
			{
				Console.Write("x = ");
				fila = int.Parse(Console.ReadLine());

				if (fila > 10 | fila <= 0)
				{
					Console.WriteLine("\nRECUERDA: Solo se admiten numeros enteros del 1 al 10\n");
				}

			} while (fila > 10 | fila <= 0);

			do
			{
				Console.Write("y = ");
				columna = int.Parse(Console.ReadLine());

				if (columna > 10 | columna <= 0)
				{
					Console.WriteLine("\nrECUERDA: Solo se admiten numeros enteros del 1 al 10\n");
				}

			} while (columna > 10 | columna <= 0);

			// Creamos la matriz con la información que nos dio el usuario
			matriz = new double[fila, columna];

			Console.WriteLine("\nAVISO: Los valores dentro de la matriz solo pueden ser mayores a 1000\n");

			// For que nos servirá para pedirle los valores de cada espacio de la matriz, el do e if nos ayudarán para que el usuario solo pueda poner numeros del 1 al 1000
			for (int i = 0; i < fila; i++)
			{
				for (int j = 0; j < columna; j++)
				{
					do
					{
						Console.Write($"\nFila {i + 1}, Columna {j + 1} = ");
						matriz[i, j] = double.Parse(Console.ReadLine());

						if (matriz[i, j] < 1000)
						{
							Console.WriteLine("\nRECUERDA: Solo se admiten números mayores que 1000\n");
						}

					} while (matriz[i,j] < 1000);
				}
			}

			Console.WriteLine("\nPasos, aplicando la conjetura de Collatz, para que el numero dentro de la matriz llegue a 1");

			// Por ultimo con los numeros que nos dio el usuario haremos la conjetura de Collatz con cada uno de esos numeros
			for (int i = 0; i < fila; i++)
			{
				for (int j = 0; j < columna; j++)
				{
					contador = 0; // Nos servira para saber cuantos pasos necesito cada numero dentro de la matriz para llegar a 1

					// Mientras el numero sea diferente a 1 se hará el while 
					while (matriz[i, j] != 1)
					{
						// Si es par lo dividimos entre 2
						if (matriz[i, j] % 2 == 0)
						{
							matriz[i, j] /= 2;
						}
						else // Si es non lo multiplicaremos por 3 y le sumaremos 1
						{
							matriz[i, j] = matriz[i, j] * 3 + 1;
						}
						contador += 1;
					}
					// Le decimos al usuario el numero de pasos de cada uno de los valores para llegar a 1 
					Console.WriteLine($"\nFila {i + 1}, Columna {j + 1}: {contador} pasos");
				}
			}


			Console.Write("\nCalifica mi programa :)");
			int calificacion = int.Parse(Console.ReadLine());
		}
	}
}
