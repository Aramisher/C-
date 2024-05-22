using System;


namespace Actividad_7___Parte_2
{
    class Class1
    {
        static void Main(String[] args)
        {
            // Declarar y asignar valores iniciales a las variables x0, x1 y eps
            double x0 = 0.0; // Primera aproximación
            double x1 = 2.0; // Segunda aproximación
            double e = 1e-6; // Precisión deseada

            // Declarar una variable para contar el número de ciclos (iteraciones)
            int ciclos = 0;

            // Declarar una variable para almacenar la aproximación actual de la solución
            double x = 0;

            // Indicamos lo que hará el programa 
            Console.WriteLine("Este programa resolverá la ecuación: \ny = x^3 - x^2 + 4x - 2\nCon el metodo de la secante\n ");

            // Iniciar un ciclo while que se ejecutará mientras el valor absoluto de la diferencia entre las dos últimas aproximaciones sea mayor que la precisión deseada eps
            while (Math.Abs(x1 - x0) > e)
            {
                // Incrementar el contador de ciclos
                ciclos++;

                // Calcular la siguiente aproximación de la solución mediante el método de la secante
                x = x1 - f(x1) * (x1 - x0) / (f(x1) - f(x0));

                // Actualizar las aproximaciones anteriores para la siguiente iteración
                x0 = x1;
                x1 = x;

            }

            // Mostrar la aproximación final de la solución
            Console.WriteLine("La raíz es: " + x);

            // Mostrar la aproximación actual de la solución y el número de ciclos
            Console.WriteLine($"Número de ciclos: " + ciclos);

            Console.WriteLine("Califica mi programa :)");
            int cali = int.Parse(Console.ReadLine());
        }


        // Definir la función f(x) = x^3 - x^2 + 4x - 2
        static double f(double x)
        {
            return Math.Pow(x, 3) - Math.Pow(x, 2) + 4 * x - 2;
        }
    }
}