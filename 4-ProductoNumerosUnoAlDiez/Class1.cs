using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2___Parte_2
{
	class Class1
	{
		static void Main(string[] args)
		{

			int calificacion;

			// Varible que nos servira para ir guardando la suma de las multiplicaciónes
			int num = 1;

			// Usamos el for para hacer el aumento y multiplicar de uno en uno del 1 al 10
			for (int i = 1; i <= 10; i += 1)
			{
				num *= i;
			}

			// Por ultimo se hace la impresion del resultado
			System.Console.WriteLine("Si multiplicas todos los numeros del 1 al 10 nos da " + num);

			System.Console.WriteLine("Califica mi programa :) ");
			calificacion = int.Parse(System.Console.ReadLine());
		}
	}
}
