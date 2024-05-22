using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4___Parte_2
{
	class Class1
	{
		static void Main(String[] args)
		{

			double n; // Variable n que ira aumentando hasta que se cumpla la condición
			double respuesta = 0; // Aqui se guardara el resultado de la operación

			// Usamos for para ir aumentando el valor de n hasta que la respuesta de 30
			for (n = 0; respuesta <= 30 ; n++)
			{
				// Hacemos la operación que nos pide el problema
				respuesta = ((Math.Pow(n, 1.5) - 1) / n);

				// Imprimimos que va pasando con la variable n y la variable respuesta
				Console.WriteLine($"n = {n + 1}     respuesta = {respuesta}");
			}

			// Imprimimos el resultado final
			Console.WriteLine($"\nPara que el resultado de la operación [(Potencia(n, 3/2) - 1) / n]\nsea mayor a 30, n debe ser igual a {n}");

			Console.WriteLine("Califica mi programa :) ");
			int calificacion = int.Parse(Console.ReadLine());
		}
	}
}
