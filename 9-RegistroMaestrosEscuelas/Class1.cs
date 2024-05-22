using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
	class Class1
	{
		static void Main(String[] args)
		{

			int calificacion;
			// Arreglo donde se guardara en la primera dimension la cantidad de escuelas en las que ha estado el usuario
			// En la segunda dimension se guardara la cantidad de maestros en cada una de esas escuelas
			// La variable guardara los nombres de todos los maestros de cada escuela
			string[][] nombreMaestros;

			// Esta variable la usaremos para pedirle al usuario la cantidad de escuelas en las que ha estado para poder guardarlo en el arreglo
			int escuelas;

			// Esta variable la usaremos para pedirle al usuario la cantidad de maestros en cada escuela y guardarlas en el arreglo
			int[] maestros;

			// Le explicamos al usuario lo que hace el programa y los datos que le pedirá 
			Console.WriteLine("Este programa te preguntará: \nEn cuantas escuelas has estado \nCuantos maestros tuviste en cada escuela \nEl nombre de cada maestro \n");

			// Le pedimos la cantidad de escuelas en las que ha estado y la guardamos en la variable escuelas para usarla a continuación
			Console.Write("¿En cuantas escuelas has estado? ");
			escuelas = int.Parse(Console.ReadLine());

			// Creamos la primera dimension dependiendo del dato que nos dio el usuario anteriormente
			nombreMaestros = new string[escuelas][];

			// Creamos la dimension de la variable maestros para ir guardando la cantidad para usar en el segundo for 
			maestros = new int[escuelas];

			Console.WriteLine("\nA continuación se te pedira la cantidad de maestros en cada escuela\n");
			
			// El for lo usaremos para pedir la cantidad de maestros en cada escuela
			for (int i = 0; i < escuelas; i++)
			{
				// Le pedimos al usuario la cantidad de maestros por escuela
				Console.Write("Maestros en escuela #" + (i + 1) + " : ");
				maestros[i] = int.Parse(Console.ReadLine());

				// Guardamos la cantidad de maestros por cada escuela en la segunda dimension del arreglo 
				nombreMaestros[i] = new string[maestros[i]];
			}

			Console.WriteLine("\nA continuación te pediremos el nombre de cada uno de los maestros\n");

			// Este for nor servira para pedirle el nombre de cada uno de los maestros de cada escuela 
			for (int i = 0; i < escuelas; i++)
			{
				for (int j = 0; j < maestros[i]; j++)
				{
					// Le pedimos al usuario el nombre dependiendo de los valores de i y j
					Console.Write("Escuela #" + (i + 1) + ", Maestro #" + (j + 1) + " : ");
					// Lo guardamos en nuestro arreglo principal
					nombreMaestros[i][j] = (Console.ReadLine()); 
				}
			}

			// Por ultimo le diremos al usuario los nombres de los profesores de cada escuela 

			for (int i = 0; i < escuelas; i++)
			{
				Console.Write("\nMaestros en escuela #" + (i + 1) + ":\n");

				for (int j = 0; j < maestros[i]; j++)
				{
					// Le pedimos al usuario el nombre dependiendo de los valores de i y j
					Console.WriteLine(nombreMaestros[i][j]);
				}
			}


			Console.Write("\nCalifica mi programa :) ");
			calificacion = int.Parse(System.Console.ReadLine());
		}
	}
}
