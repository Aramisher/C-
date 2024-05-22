using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3_Parte_2
{
	class Class1
	{
		static void Main(String[] args)
		{
			int exit;

			// Arreglo que guardara el valor de todas las calificaciones
			int[] calificacion;

			// Variable que guardara la cantidad de calificaciones que quiere introducir el usuario
			int numCalif;

			// Variable donde se guardará el acumulado de todas las calificaciones
			// Despues guardaremos el promedio de esas calificaciones en esta misma variable dividiendolo entre la cantidad de calificaciones
			int promedio = 0;

			// Variables donde se guardará la calificación mas baja y la mas alta 
			int caliBaja = 100;
			int caliAlta = 0;

			// Le indicamos lo que hace el programa al usuario 
			System.Console.WriteLine("Este programa te servira para guardar tus calificaciones y te dara:");
			System.Console.WriteLine("1. El promedio de tus calificaciones \n2. Tu calificación mas alta \n3. Tu calificación mas baja \n");

			// Le pedimos la cantidad de calificaciones que introducira
			System.Console.Write("¿Cuantas calificaciones vas a introducir? ");
			numCalif = int.Parse(System.Console.ReadLine());

			// Avisamos sobre las limitaciones de los datos que va a introducir
			System.Console.WriteLine("\nAVISO: Las calificaciones tendran que ser numeros enteros del 1 al 100\n");

			// El tamaño del arreglo dependera de lo que introduzca el usuario
			calificacion = new int[numCalif];

			// El for lo usaremos para que el usuario introduzca cada una de sus calificaciones
			// Para que evalue dentro del for cual es la calificación mas baja y alta y para que vaya acumulando las calificaciones para promediarlas 
			for (int i = 0; i <= numCalif - 1; i++)
			{
				// El do nos servira para preguntar otra vez por la calificación en caso de que se introduzca un numero que no sea entre 0 y 100
				do
				{
					// Le pedimos el valor de cada calificación
					System.Console.Write("Calificación " + (i + 1) + ": ");
					calificacion[i] = int.Parse(System.Console.ReadLine());

					// En caso de dar un numero no valido se le repetira el limite del programa y se le pedira la calificación nuevamente
					if (calificacion[i] < 0 | calificacion[i] > 100)
					{
						System.Console.WriteLine("\nSolo se admiten numeros del 1 al 100\n");
					}

				} while(calificacion[i] < 0 | calificacion[i] > 100);

				// if que ayudará a guardar la calificación mas alta
				if (calificacion[i] > caliAlta)
				{
					caliAlta = calificacion[i];
				}

				// if que ayudará a guardar la calificación mas baja 
				if (calificacion[i] < caliBaja)
				{
					caliBaja = calificacion[i];
				}

				// Acumulamos todos los valores de las calificaciónes
				promedio += calificacion[i];
			}

			System.Console.WriteLine();

			// Hacemos el promedio de las calificaciones dividiendo la suma de las calificaciónes entre el número de calificacioners
			promedio /= numCalif;

			// Le damos al usuario el promedio de sus calificaciones y cual fue la mas baja y la mas alta 
			System.Console.WriteLine("Promedio: " + promedio);
			System.Console.WriteLine("Calificación mas baja: " + caliBaja);
			System.Console.WriteLine("Calificación mas alta: " + caliAlta);

			System.Console.WriteLine();

			System.Console.Write("Califica mi programa :)");
			exit = int.Parse(System.Console.ReadLine());
		}
	}
}
