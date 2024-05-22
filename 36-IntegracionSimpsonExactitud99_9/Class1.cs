using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace IntegracionNumerica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula la integral de (sen(x) / x) + 1 de x = -10 hasta x = 10 mediante la regla de Simpson.");

            double resultado1 = IntegralSimpson(-10, 10, 1000);
            Console.WriteLine($"Resultado con 1000 elementos: {resultado1}");

            int[] elementos = { 2, 5, 10, 20, 100, 5000, 10000 };
            Exactitud99_9(elementos);

            Console.ReadKey();
        }

        // Función para calcular la integral utilizando la regla de Simpson
        static double IntegralSimpson(double a, double b, int n)
        {
            double h = (b - a) / n;
            double sumaPar = 0;
            double sumaImpar = 0;
            double x;

            for (int i = 1; i < n; i += 2)
            {
                x = a + i * h;
                sumaImpar += Funcion(x);
            }

            for (int i = 2; i < n - 1; i += 2)
            {
                x = a + i * h;
                sumaPar += Funcion(x);
            }

            double integral = h * (Funcion(a) + Funcion(b) + 4 * sumaImpar + 2 * sumaPar) / 3;
            return integral;
        }

        // Función a integrar: (sen(x) / x) + 1
        static double Funcion(double x)
        {
            if (Math.Abs(x) < 1e-10) // Evitar la división por cero
                return 2;
            else
                return (Math.Sin(x) / x) + 1;
        }

        // Función para determinar cuántos elementos se necesitan para tener una exactitud del 99.9%
        static void Exactitud99_9(int[] elementos)
        {
            Console.WriteLine("\nExactitud del 99.9%:");

            double resultadoExacto = IntegralSimpson(-10, 10, 10000); // Aproximación "exacta" utilizando 10000 elementos
            double resultado;

            foreach (int n in elementos)
            {
                resultado = IntegralSimpson(-10, 10, n);
                double error = Math.Abs((resultado - resultadoExacto) / resultadoExacto) * 100;

                Console.WriteLine($"Elementos: {n}, Error: {error}%");

                if (error <= 0.1)
                {
                    Console.WriteLine($"Se necesitan {n} elementos para tener una exactitud del 99.9%.");
                    break;
                }
            }
        }
    }
}

