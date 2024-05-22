using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
	class Class1
	{
		static void Main(string[] args)
		{
			// La variable de entrada será string para poder saber si el numero que pone el usuario es entero o decimal
			string num;

			// Esta variable la usaremos para saber si el numero que introduce el usuario es decimal o entero
			bool decimales = false;

			// Variable que en caso de que el numero introducido por el usuario sea primo se volvera TRUE
			bool primo = true;

			// Variable que guarda la calificación que le dan al programa :)
			int calificacion;

			// Le explicamos al usuario el programa y las limitaciones de los valores de entrada 
			System.Console.WriteLine("Este programa te pedira un numero entero o decimal positivo y te dira si es primo o no en caso de ser entero y se buscara su raiz cuadrada");
			System.Console.WriteLine();

			// Le pedimos el valor de entrada 
			System.Console.Write("Introduce un numero: ");
			num = (System.Console.ReadLine());

			System.Console.WriteLine();

			// Creamos una variable que guardara cada caracter de la variable num dentro de un arreglo
			char[] punto = num.ToCharArray();

			// Ya que guardamos todos los numeros como caracteres individuales buscaremos en cada caracter un punto (.) para saber si es decimal o no
			for (int i = 0; i < punto.Length; i++)
			{
				// En caso de que si haya un punto la variable decimal se convierte en true para confirmar que nuestro numero si es decimal
				if (punto[i] == '.')
				{
					decimales = true;
				}
			}

			// Como la variable num es un string tenemos que convertirlo a double y luego a int para despues evaluar si es primo o no
			// Hice 2 conversiones ya que me mandaba error cuando convertia de String "1.23" a int 
			double doubleNum = Convert.ToDouble(num);
			int intNum = Convert.ToInt32(doubleNum);

			// Este if nos servira para decirle al usuario si el numero es decimal o entero
			if (decimales == true)
			{
				System.Console.WriteLine("El numero introducido es decimal");
			}
			else
			{
				System.Console.Write("El numero introducido es entero");

				// En caso de ser entero tambien tenemos que saber si es primo o no y para eso usamos el for a continuación
				for (int i = intNum - 1; i > 1; i--)
				{
					// En caso de que ningun numero menor al valor de entrada dé residuo = 0 la variable primo se quedara como TRUE
					// Ya que un numero primo solo se puede dividir entre el mismo y 1 para que de entero
					if (intNum % i == 0)
					{
						primo = false;
					}
				}

				// Le decimos al usuario si el numero que introdujo es primo o no
				if (primo == false)
				{
					System.Console.WriteLine(" y no es primo");
				}
				else
				{
					System.Console.WriteLine(" y es primo");
				}

			}

			System.Console.WriteLine();

			// Por ultimo tenemos que sacar la raiz cuadrada del numero que nos dio el usuario dividiendolo
			// entre todos los numeros posibles, hasta centésimas.

			// Variable que se usara para terminar el loop
			bool exit = false;

			// En esta variable se guardara el resultado de la division del numero del usuario entre todos los numeros posibles
			double raiz; 

			// El for se usa para poder dividir el numero introducido entre todos los resultados posibles
			for (double i = 0; exit == false; i += 0.01)
			{
				// Usamos doubleNum ya que es el numero introducido por el usuario ya convertido a variable double
				raiz = doubleNum / i;

				// El if será para verificar si el numero de la division (raiz) es la raiz cuadrada del numero introducido
				// con precisión en centesimas 
				if (raiz > i - 0.01 & raiz < i + 0.01)
				{
					// Se reduce si es necesario la respuesta para solo mostrar hasta centesimas
					double raizCuadrada = Math.Round(raiz, 2);
					System.Console.WriteLine("La raiz cuadrada del numero introducido es " + raizCuadrada);
					

					// Activamos la variable exit para que termine el loop
					exit = true;
				}
				System.Console.WriteLine(i);

			}

			System.Console.WriteLine();
			System.Console.WriteLine("Califica mi programa :) ");
			calificacion = int.Parse(System.Console.ReadLine());

		}
	}
}
