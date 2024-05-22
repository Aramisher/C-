using System;

namespace Actividad_7___Parte_3
{
	class Class1
	{
        static void Main(string[] args)
        {
            double x0 = 1; // valor inicial de x
            double x1 = 0; // valor de x en la siguiente iteración

            double funcion_x0 = 0; // valor de la función en x0
            double funcion_x1 = 0; // valor de la función en x1
            double derivada_x0 = 0; // valor de la derivada de la función en x0

            double error = 1; // valor del error inicial
            int ciclos = 0; // contador de ciclos

            // Indicamos lo que hará el programa 
            Console.WriteLine("Este programa resolverá la ecuación: \ny = x^3 - x^2 + 4x - 2\nCon el metodo de Newton-Raphson\n ");

            // bucle que se repetirá mientras el error sea mayor que 0.0001
            while (error > 0.0001)
            {
                funcion_x0 = Math.Pow(x0, 3) - Math.Pow(x0, 2) + 4 * x0 - 2;
                derivada_x0 = 3 * Math.Pow(x0, 2) - 2 * x0 + 4;

                x1 = x0 - funcion_x0 / derivada_x0;

                funcion_x1 = Math.Pow(x1, 3) - Math.Pow(x1, 2) + 4 * x1 - 2;

                error = Math.Abs(x1 - x0);
                x0 = x1;

                ciclos++;
            }

            // Mostrar la aproximación final de la solución
            Console.WriteLine("La raíz de la ecuación es: " + x1);

            // Mostrar el número de ciclos 
            Console.WriteLine("Número de ciclos: " + ciclos);

            Console.WriteLine("\nCalifica mi programa :)");
            int cali = int.Parse(Console.ReadLine());
        }
    }
}
