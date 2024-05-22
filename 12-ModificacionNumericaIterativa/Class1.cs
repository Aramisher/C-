using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4___Parte_3
{
	class Class1
	{
		static void Main(String[] args)
		{

			// Variable de entrada
			int num;

			// Le explicamos al usuario que hace el programa y sus limites
			Console.WriteLine("Este programa te pedirá un numero, si: \nSi es divisible entre 5 se le sumara 2 \nSi es divible entre 7 se le sumara 1\nSi no, se le sumaran 3");
			Console.WriteLine("\nEste proceso se hará 1000 veces\n");

			// Le pedimos el valor de entrada
			Console.Write("Introduce un numero: ");
			num = int.Parse(Console.ReadLine());

			// Usamos el for para hacer el proceso 1000 veces
			for (int i = 0; i < 1000; i++)
			{
				// Si es multiplo de 7 se le sumara 1
				if (num % 7 == 0)
				{
					Console.WriteLine(num + " + 1 = " + (num + 1));
					num += 1;
				} // Si es multiplo de 5 se le sumaran 2
				else if(num % 5 == 0)
				{
					Console.WriteLine(num + " + 2 = " + (num + 2));
					num += 2;
				}
				else // Si no es multiplo de ninguno se le sumaran 3
				{
					Console.WriteLine(num + " + 3 = " + (num + 3));
					num += 3;
				}
			}

			Console.WriteLine("Califica mi programa :) ");
			int calificacion = int.Parse(Console.ReadLine());
		}
	}
}
