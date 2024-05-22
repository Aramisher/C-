using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3___Parte_1
{
	class Class1
	{
		static void Main(String[] args)
		{
			int cali;

			// Variables de entrada donde se guardaran los parametros de la matriz 
			int renglon;
			int columna;

			// Variable tipo matriz donde se guardaran todos los valores de la matriz
			int[,] matriz;

			// Variable donde se guardaran los valores de la matriz multiplicada
			int[,] matrizMulti;

			// Variable de entrada que nos servira para multiplicar la matriz por el numero que quiera el usuario
			int multi;

			// Le decimos como funciona el programa y los valores que le pediremos
			System.Console.WriteLine("Programa que te permitirá crear tu propia matriz y lo multriplicará por el numero que introduzcas");
			System.Console.WriteLine("Se te pedira el numero de renglones, el numero de columnas y todos lo valores dentro de la matriz\n");

			// Le pedimos los parametros de la matriz
			System.Console.Write("\n¿Cuantos renglones tendra tu matriz? ");
			renglon = int.Parse(System.Console.ReadLine());

			System.Console.Write("\n¿Cuantas columnas tendrá tu matriz? ");
			columna = int.Parse(System.Console.ReadLine());

			// Creamos la matriz con los datos proporcionados por el usuario
			matriz = new int[renglon, columna];
			matrizMulti = new int[renglon, columna];

			System.Console.WriteLine();

			// Le preguntamos por cuanto multiplicará la matriz que va a introducir a continuación
			System.Console.Write("\n La matriz será multiplicada por: ");
			multi = int.Parse(System.Console.ReadLine());

			System.Console.WriteLine();

			// Este for nos servira para pedirle y guardar cada valor de la matriz y para ir guardando en matrizMulti la matriz ya multiplicada
			for (int i = 0; i < columna; i++)
			{
				for (int j = 0; j < renglon; j++)
				{
					System.Console.Write("Renglon " + (i + 1) + ", Columna " + (j + 1) + ": ");
					matriz[j, i] = int.Parse(System.Console.ReadLine());
					matrizMulti[j, i] = matriz[j, i] * multi; 
				}
			}

			System.Console.WriteLine();

			// Con este for imprimiremos la matriz primero imprimiendo todas las columnas y luego pasando al siguiente renglon
			for (int i = 0; i < columna; i++)
			{
				// Se imprimen los valores del renglon i de la matriz
				for (int j = 0; j < renglon; j++)
				{
					System.Console.Write(matriz[j, i] + "  ");
				}

				// Imprimimos el espacio que hay entre matrices
				if (i < columna - 1)
				{
					System.Console.Write("                   ");
				}
				else // Al llegar a la ultima linea pondremos por cuanto se multiplica la matriz para darle forma a la operación en la consola
				{
					System.Console.Write("    *    " + multi + "    =    ");
				}

				// Despues de imprimir los valores de la primera matriz y el espacio se imprimiran los valores de la matriz multiplicada
				for (int j = 0; j < renglon; j++)
				{
					System.Console.Write(matrizMulti[j, i] + "  ");
				}
				System.Console.WriteLine("\n");
			}

			System.Console.Write("");
			cali = int.Parse(System.Console.ReadLine());
		}
	}
}
