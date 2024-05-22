using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = -10;
            double b = 10;
            int n = 1000;

            Console.WriteLine("Este programa calcula la integral de la función (sen(x) / x) + 1 en el intervalo [-10, 10] utilizando dos métodos diferentes:");
            Console.WriteLine("1. Método del rectángulo");
            Console.WriteLine("2. Método del trapecio");

            // Calcular resultados
            double resultRectangular = RectangularIntegral(a, b, n);
            double resultTrapezoidal = TrapezoidalIntegral(a, b, n);

            // Mostrar resultados
            Console.WriteLine($"\nResultado utilizando el método del rectángulo: {resultRectangular}");
            Console.WriteLine($"Resultado utilizando el método del trapecio: {resultTrapezoidal}");
            Console.ReadLine();
        }

        // Definimos la función (sen(x) / x) + 1
        static double Func(double x)
        {
            if (x == 0) return 1;
            return (Math.Sin(x) / x) + 1;
        }

        // Método del rectángulo
        static double RectangularIntegral(double a, double b, int n)
        {
            // Calculamos el ancho de cada rectángulo (h)
            double h = (b - a) / n;
            double sum = 0;

            // Iteramos sobre cada rectángulo
            for (int i = 0; i < n; i++)
            {
                // Calculamos la posición x en el eje horizontal
                double x = a + i * h;
                // Sumamos el valor de la función en el punto x al acumulador
                sum += Func(x);
            }

            // Multiplicamos la suma por el ancho de cada rectángulo (h) para obtener el resultado
            return sum * h;
        }

        // Método del trapecio
        static double TrapezoidalIntegral(double a, double b, int n)
        {
            // Calculamos el ancho de cada trapecio (h)
            double h = (b - a) / n;
            // Iniciamos la suma con los valores de la función en los extremos (a y b)
            double sum = 0.5 * (Func(a) + Func(b));

            // Iteramos sobre cada trapecio
            for (int i = 1; i < n; i++)
            {
                // Calculamos la posición x en el eje horizontal
                double x = a + i * h;
                // Sumamos el valor de la función en el punto x al acumulador
                sum += Func(x);
            }

            // Multiplicamos la suma por el ancho de cada trapecio (h) para obtener el resultado
            return sum * h;
        }
    }
}
