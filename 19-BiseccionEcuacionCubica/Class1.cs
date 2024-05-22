using System;

namespace Actividad_7___Parte_1
{
	class Class1
	{
		static void Main(String[] args)
		{
            // Declarar y asignar valores iniciales a las variables a, b y eps
            double a = 0.0; // Extremo izquierdo del intervalo
            double b = 2.0; // Extremo derecho del intervalo
            double e = 1e-6; // Precisión deseada

            // Declarar una variable para contar el número de ciclos 
            int ciclos = 0;

            // Declarar una variable para almacenar la aproximación actual de la solución
            double c;

            // Indicamos lo que hará el programa 
            Console.WriteLine("Este programa resolverá la ecuación: \ny = x^3 - x^2 + 4x - 2\nCon el metodo de bisección\n ");

            // Iniciar un ciclo while que se ejecutará mientras la longitud del intervalo [a, b] sea mayor que la precisión deseada eps
            while (Math.Abs(b - a) > e)
            {
                // Incrementar el contador de ciclos
                ciclos++;

                // Calcular la aproximación actual de la solución como el punto medio del intervalo [a, b]
                c = (a + b) / 2;

                // Calcular el valor de la función en la aproximación actual
                double funcionAprox = Math.Pow(c, 3) - Math.Pow(c, 2) + 4 * c - 2;

                // Calcular el valor de la función en el extremo izquierdo del intervalo
                double funcionExt = Math.Pow(a, 3) - Math.Pow(a, 2) + 4 * a - 2;

                // Verificar si el signo del valor de la función en la aproximación actual es diferente al del extremo izquierdo del intervalo
                if (funcionAprox * funcionExt < 0)
                {
                    // Si el signo es diferente, la solución se encuentra en el subintervalo [a, c]
                    // Actualizar el valor del extremo derecho del intervalo para que sea igual a la aproximación actual
                    b = c;
                }
                else
                {
                    // Si el signo es el mismo, la solución se encuentra en el subintervalo [c, b]
                    // Actualizar el valor del extremo izquierdo del intervalo para que sea igual a la aproximación actual
                    a = c;
                }
            }

            // Mostrar la aproximación final de la solución (el punto medio del intervalo [a, b])
            Console.WriteLine("La raíz es: " + ((a + b) / 2));

            // Mostrar el número de ciclos 
            Console.WriteLine("Número de ciclos: " + ciclos);

            Console.WriteLine("\nCalifica mi programa :)");
            int cali = int.Parse(Console.ReadLine());
        }
	}
}
