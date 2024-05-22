using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4___Parte_1
{
	class Class1
	{
		static void Main(String[] args)
		{
			// Aqui guardaremos el resultado de la operación
			double resultado;

			// Esta variable nos sirve para poder decirle al usuario en que momento cambia el signo
			double resultadoAnterior = 0;

			Console.WriteLine("Se esta haciendo la operación \n n^2 - 100n +900\nSe hará el aumento de n 1000 veces y el programa indicara cuando se hizo un cambio de signo");

			// Usamos un for para hacer el proceso 1000 veces
			for (int n = 0; n < 1000; n++)
			{
				// Hacemos la operación que nos pide el problema
				resultado = (Math.Pow(n, 2) - (100 * n) + 900);
				Console.WriteLine(n + ". " + resultado);

				// Si resultado = 0 significa que ha cambiado de signo
				if (resultado == 0)
				{
					if (resultadoAnterior < 0)
					{
						Console.WriteLine("El signo cambia en la posición " + n);
					}
					if (resultadoAnterior > 0)
					{
						Console.WriteLine("El signo cambia en la posición " + (n + 1));
					}
				}
				// Guardamos el resultado anterior para poder dar una respuesta de salida correcta
				resultadoAnterior = resultado;
			}


			Console.Write("Califica mi programa :) ");
			int calificacion = int.Parse(Console.ReadLine());
		}
	}
}
