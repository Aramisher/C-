using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4___Parte_1
{
	class Class1
	{
		static void Main(String[] args)
		{

			int calificacion;

			// Declaramos el arreglo donde guardaremos todos los valores
			// Le damos 100 espacios ya que no sabemos cuantos numeros introducira el usuario
			int[] num = new int[100];

			// En esta variable guardaremos la cantidad de numeros que introducirá el usuario
			int conteo = 0;

			// Aqui se guardara el total de las cantidades dadas por el usuario para promediarlas 
			int acumulado = 0;

			// El promedio de los numeros dados se guardara en esta variable
			int promedio;

			// Cuando el usuario introduzca 0 para terminar con el proceso se activara la variable exit para salir del for
			bool exit = false;


			// Le indicamos al usuario las instrucciones, los datos de salida y los limites del programa 
			Console.WriteLine("Este programa te pedira números ENTEROS MENORES que 100 y te dara:");
			Console.WriteLine("1. La cantidad de números introducidos \n2. La suma de esos numeros \n3. Promedio");
			Console.WriteLine("AVISO: Para terminar el proceso introduce el número 0 \n");

			// Este for lo usaremos para pedir todos los valores de num[] al usuario
			for (int i = 0; exit == false; i++)
			{
				// En caso de que el usuario dé un numero no valido se repetirá el do-while hasta que introduzcan un valor correcto
				do
				{
					// Le pedimos el numero al usuario
					Console.Write("Número " + (i + 1) + ": ");
					num[i] = int.Parse(Console.ReadLine());

					// Si el numero esta entre 0 y 100 seguimos con el procedimiento
					if (num[i] >= 0 & num[i] <= 100)
					{
						// Si el numero es diferente a 0 se hace lo siguiente 
						if (num[i] != 0)
						{
							// Agregamos 1 al numero de numeros introducidos por el usuario
							conteo++;
							// Guardamos todos los valores acumulados para despues promediar los numeros
							acumulado += num[i];
						} // En caso de que el numero introducido sea 0 activamos la variable exit para terminar con el proceso
						else
						{
							exit = true;
						}
					}
					// En caso de que no sea un numero entre 0 y 50 se le recuerda al usuario los limites del programa
					else
					{
						Console.WriteLine("\nEl numero introducido es incorrecto\nRECUERDA: Solo numeros enteros del 1 al 100\n          Numero 0 solo para terminar proceso\n");
					}
				  // Se repite el do-while mientras el numero no sea entre 0 y 50
				} while (num[i] < 0 | num[i] > 100);
			}

			// Sacamos el promedio de los numeros introducidos
			promedio = acumulado / conteo;

			// Le imprimimos al usuario todos los valores de salida del programa
			Console.WriteLine("\nIntrodujiste " + conteo + " numeros");
			Console.WriteLine("La suma de todos los numeros introducidos es " + acumulado);
			Console.WriteLine("Promedio = " + promedio);


			Console.WriteLine("\nCalifica mi programa :) ");
			calificacion = int.Parse(Console.ReadLine());
		}
	}
}
