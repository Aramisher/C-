using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2___Parte_1
{
	class Class1
	{
		static void Main(string[] args)
		{
			int calificacion;

			// Variable de entrada que se le da el valor de 24 para que cumpla el primer while
			int hora_dormir = 24;

			// Variable de salida que nos dira la hora a la que se deberia de despertar el usuario
			int hora_despertar;

			// Se explica lo que hace el programa al usuario y se deja en claro las limitaciones del programa
			System.Console.WriteLine("Este programa te ayudara a saber a que hora es recomensable despertarte segun la hora en la que duermes");
			System.Console.WriteLine("AVISO: que solo se permiten numeros enteros del 0 al 23");
			System.Console.WriteLine();

			// Se usa el while para comfirmar que el usuario este poniendo un numero entre el 0 y el 23
			while (hora_dormir > 23 | hora_dormir < 0)
			{
				System.Console.WriteLine("¿A que hora te duermes? ");
				hora_dormir = int.Parse(System.Console.ReadLine());
				
				// En caso que el usuario introduzca un dato incorrecto se usa el if para mandar el mensaje de ERROR
				if (hora_dormir > 23 | hora_dormir < 0)
				{
					System.Console.WriteLine();
					System.Console.WriteLine("ERROR: La hora introducida no es valida, favor de poner una numero entero del 0 al 23");
					System.Console.WriteLine();
				}
			}

			System.Console.WriteLine();
			
			// En este caso usaremos switch para especificar que pasara en cada caso
			switch (hora_dormir)
			{
				case 23:
				case 0:
				case 1:
					System.Console.WriteLine("Duerme usted un poco tarde, trate de descansar más.");
					break;
				case 2:
				case 3:
				case 4:
					System.Console.WriteLine("Usted duerme muy tarde, eso no es bueno para la salud.");
					break;
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
					System.Console.WriteLine("Supongo que duerme a estas horas porque tiene un trabajo noctorno, ");
					break;
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
				case 16:
				case 17:
				case 18:
					System.Console.WriteLine("Usted tiene un horario de sueño muy extraño, ");
					break;
				case 19:
				case 20:
					System.Console.WriteLine("Usted duerme muy temprano, ");
					break;
				case 21:
				case 22:
					System.Console.WriteLine("Usted duerme a muy buena hora, felicidades, ");
					break;
			}

			// Se le agregan 8 horas a la hora de dormir ya que esa seria la hora ideal para despertarse
			hora_despertar = hora_dormir + 8;

			// Si le agregamos 8 a los numeros del 16 al 23 no daria una hora correcta
			// Se usa el if para que a esos numeros le podamos restar 24 y nos de la hora correcta
			// Ejemplo: Hora de dormir 16 + 8 horas de sueño = 24, 24 no es una hora correcta por lo que restamos 24 y nos da 0, la hora correcta
			if (hora_despertar >= 24)
			{
				hora_despertar -= 24;
			}

			//Por ultimo le decimos al usuario la hora recomendada para despertarse
			System.Console.WriteLine("Hora recomendada para despertarse: " + hora_despertar + ":00");			
			System.Console.WriteLine();

			System.Console.WriteLine("Califica mi programa :) ");
			calificacion = int.Parse(System.Console.ReadLine());

		}
	}
}
