using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
	class Class1
	{
		static void Main(string[] args)
		{
			float valor_1, valor_2, valor_3, valor_4, calificacion; //Variables de entradad
			float operacion_1, operacion_2, operacion_3, operacion_4; //Variables de salida y donde se guardaran las operaciones
			bool compara_1, compara_2, compara_3, compara_4, compara_5, compara_6; //Variables de salida y donde se haran las comparaciones entre variables 

			// Se le explica que se hará con los valores que se pediran a continuación 
			System.Console.WriteLine("Se te pediran 4 numeros enteros para hacer operaciones y comparaciones entre ellos");

			// Pedimos los 4 valores que el usuario introducirá 
			System.Console.Write("Escribe el 1er. valor: ");
			valor_1 = float.Parse(System.Console.ReadLine());

			System.Console.Write("Escribe el 2do. valor: ");
			valor_2 = float.Parse(System.Console.ReadLine());

			System.Console.Write("Escribe el 3er. valor: ");
			valor_3 = float.Parse(System.Console.ReadLine());

			System.Console.Write("Escribe el 4to. valor: ");
			valor_4 = float.Parse(System.Console.ReadLine());

			// Se hacen las operaciones correspondientes que se guardaran en las variable de operacion_x
			operacion_1 = valor_1 + valor_2 + valor_3 + valor_4;

			operacion_2 = valor_1 * valor_2 * valor_3 * valor_4;

			operacion_3 = (valor_1 / valor_2) + (valor_3 / valor_4);

			operacion_4 = (operacion_1 / operacion_2);

			// Se hacen las comparaciones correspondientes y se guardaran los valores en compara_x
			compara_1 = valor_1 != valor_3;

			compara_2 = valor_2 == valor_4;

			compara_3 = valor_1 > valor_3;

			// Usamos el if ya que no podemos usar | entre numeros flotantes y valor_1 tiene que ser mayor que valor_3 O valor_4
			if (valor_1 < valor_3)
			{
				compara_3 = valor_1 > valor_4;
			}

			compara_4 = valor_2 < operacion_3;

			compara_5 = (compara_1 | compara_2) == true;

			compara_6 = (compara_3 | compara_4) == true;

			// Por ultimo se hará la impresión de los resultados y se le enseñara al usuario las operaciones que hizo el programa

			// Aqui se mostraran las operaciones del 1 al 4
			System.Console.WriteLine();

			System.Console.WriteLine("Las operaciones son:");

			System.Console.WriteLine("Operación 1 = " + valor_1 + " + " + valor_2 + " + " + valor_3 + " + " + valor_4 + " = " + operacion_1);

			System.Console.WriteLine("Operación 2 = " + valor_1 + " * " + valor_2 + " * " + valor_3 + " * " + valor_4 + " = " + operacion_2);

			System.Console.WriteLine("Operación 3 = " + "(" + valor_1 + "/" + valor_2 + ") + (" + valor_3 + "/" + valor_4 + ") = " + operacion_3);

			System.Console.WriteLine("Operación 4 = " + operacion_1 + "/" + operacion_2 + " = " + operacion_4);

			// Aqui se mostraran las comparaciones del 1 al 5
			System.Console.WriteLine();

			System.Console.WriteLine("Comparación 1 = " + "(" + valor_1 + " != " + valor_3 + " ) = " + compara_1);

			System.Console.WriteLine("Comparación 2 = " + "(" + valor_2 + " == " + valor_4 + " ) = " + compara_2);

			System.Console.WriteLine("Comporación 3 = " + "(" + valor_1 + " > (" + valor_3 + " | " + valor_4 + ")) = " + compara_3);

			System.Console.WriteLine("Comporación 4 = " + "(" + valor_2 + " < " + operacion_3 + ") = " + compara_4);

			System.Console.WriteLine("Comparación 5 = " + "((" + compara_1 + " | " + compara_2 + ") = True) = " + compara_5);

			System.Console.WriteLine("Comparación 6 = " + "((" + compara_3 + " | " + compara_4 + ") = True) = " + compara_6);

			System.Console.WriteLine();

			break;
		}
	}
}
