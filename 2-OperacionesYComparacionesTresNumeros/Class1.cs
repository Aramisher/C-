using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
	class Class1
	{
		static void Main(string[] args)
		{

			int calificacion;
			float numero_1, numero_2, numero_3; // Variables de entrada
			float opera_1, opera_2, opera_3; // Varibles donde se guardaran las primeras 3 operaciones
			bool contraste_1, contraste_2, contraste_3; // Varibles donde se guardaran las comparaciones

			// Se le indica al usuario que tiene que hacer y que hará el programa
			System.Console.WriteLine("Se te pediran 3 numeros a continuación para hacer operaciones y comparaciones entre esos numeros");
			System.Console.WriteLine();

			// Se piden todos los numero necesarios para hacer funcionar el programa 
			System.Console.Write("Numero 1: ");
			numero_1 = float.Parse(System.Console.ReadLine());

			System.Console.Write("Numero 2: ");
			numero_2 = float.Parse(System.Console.ReadLine());

			System.Console.Write("Numero 3: ");
			numero_3 = float.Parse(System.Console.ReadLine());

			// A continuacion se hacen las operaciones que nos pide la actividad y lo guardamos en opera_x

			opera_1 = (numero_1 + numero_2) - numero_3;

			opera_2 = numero_1 * numero_2 * numero_3;

			opera_3 = numero_2 % numero_3;

			// Despues de las operaciones hacemos las comparaciones correspondientes

			contraste_1 = numero_1 == numero_3;
			
			contraste_2 = (numero_1 > numero_2) & (numero_2 > numero_3);

			contraste_3 = (contraste_1 & contraste_2) == true;

			// Se mostraran los resultados de las operaciones al usuario

			System.Console.WriteLine();

			System.Console.WriteLine("Operación 1 = (" + numero_1 + " + " + numero_2 + ")" + " - " + numero_3 + " = " + opera_1);

			System.Console.WriteLine("Operación 2 = " + numero_1 + " * " + numero_2 + " * " + numero_3 + " = " + opera_2);

			System.Console.WriteLine("Operación 3 = " + numero_2 + " % " + numero_3 + " = " + opera_3);

			// Se mostraran los resultados de las comparaciones al usuario

			System.Console.WriteLine();

			System.Console.WriteLine("Comparación 1 = (" + numero_1 + " == " + numero_3 + ") = " + contraste_1);

			System.Console.WriteLine("Comparación 2 = " + numero_1 + " > " + numero_2 + " > " + numero_3 + " = " + contraste_2);

			System.Console.WriteLine("Comparación 3 = ((" + contraste_1 + " & " + contraste_2 + ") == true) = " + contraste_3);

			break;

		}
	}
}
