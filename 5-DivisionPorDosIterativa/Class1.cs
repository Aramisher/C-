using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2___Parte_3
{
	class Class1
	{
		static void Main(string[] args)
		{

			int calificacion;
			int num; // Aqui se guardara el numero que se irá dividiendo
			int res; // Aqui se guardara el valor del residuo

			// Le pedimos al usuario un numero entero positivo
			System.Console.WriteLine("Escribe un numero entero positivo: ");
			num = int.Parse(System.Console.ReadLine());


			// El While nos servira para que mientras nuestro numero sea mayor que 1 se siga dividiendo entre 2
			while (num > 1)
			{
				// Guardamos el valor de 0 o 1 en la variable residuo para saber si sumarle 1 o no 
				res = num % 2;

				// En el caso de que el residuo sea 1 le sumaremos 1 para poder seguir con la division de enteros entre 2
				if (res == 1)
				{
					System.Console.Write(num + " ");
					num += 1;

				}

				System.Console.Write(num + " ");

				num /= 2;
			}

			// Agregamos un 1 al final para dar por terminado el ejercicio
			System.Console.Write("1");

			System.Console.WriteLine();
			System.Console.WriteLine("Califica mi programa :) ");
			calificacion = int.Parse(System.Console.ReadLine());
		}
	}
}
