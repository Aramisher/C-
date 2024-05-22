using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4___Parte_2
{
	class Class1
	{
		static void Main(String[] args)
		{

			// Usamos decimal ya que manejaremos numeros muy grandes
			// Variables de entrada que nos serviran para empezar la secuencia de fibonacci
			decimal fibonacci1;
			decimal fibonacci2;

			// Variable que nos ayudara a ir guardando el resultado para imprimirlo al usuario conforme avanza el for
			decimal fibonacciResultado;

			// Le decimos al usuario que hace el programa y le explicamos las limitaciones de los valores de entrada
			Console.WriteLine("Este programa creará una secuencia de fibonacci segun los numeros que introduzcas");
			Console.WriteLine("AVISO: El 1er. tiene que ser menor que el 2do. número introducido y ambos tienen que ser positivos\n");

			// do para pedir 1er. valor
			do
			{
				Console.Write("1er. Valor: ");
				fibonacci1 = decimal.Parse(Console.ReadLine());

				// Mensaje de erros en caso de que introduzca un valor igual o menor a 0
				if (fibonacci1 <= 0)
				{
					Console.WriteLine("\nHas introducido un valor incorrecto, recuerda que \nsolo se admiten numeros positivos\n");
				}
			} while (fibonacci1 <= 0); // Si el valor es igual o menor a 0 le pediremos el valor nuevamente

			// do para pedir 2do. valor 
			do
			{
				Console.Write("2do. Valor: ");
				fibonacci2 = decimal.Parse(Console.ReadLine());

				// Mensaje de error en caso de que introduzca un valor menor al 1ro.
				if (fibonacci1 >= fibonacci2)
				{
					Console.WriteLine("\nHas introducido un valor incorrecto, recuerda que el 2do. valor \ntiene que ser mayor que el 1er. valor\n");
				}
			} while (fibonacci1 >= fibonacci2); // Si el 2do. valor es menor que el primero le pediremos el valor nuevamente

			Console.WriteLine();

			// for para hacer la secuencia de fibonacci exactamente 100 veces
			for (int i = 0; i < 100; i++)
			{
				// El resultado siempre va a ser los 2 numeros anteriores sumados
				fibonacciResultado = fibonacci1 + fibonacci2;

				Console.WriteLine($"{i + 1}. {fibonacci1} + {fibonacci2} = {fibonacciResultado}");

				// Remplazamos los valores para continuar con la secuencia de fibonacci
				fibonacci1 = fibonacci2;
				fibonacci2 = fibonacciResultado;
			}

			Console.Write("Califica mi programa :) ");
			int calificacion = int.Parse(Console.ReadLine());

		}
	}
}
