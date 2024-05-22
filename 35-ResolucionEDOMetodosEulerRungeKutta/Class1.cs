using System;

namespace Tarea_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valores iniciales
            double xInicial = 7;
            double fInicial = 2;
            double[] pasos = { 1, 0.4, 0.2, 0.02, 0.002 };

            Console.WriteLine("Este programa resuelve la ecuación diferencial df(x) / dx = -sin(x) + 5f(x) cos(x)");
            Console.WriteLine("Usando el método de Euler y el método de Runge-Kutta.");
            Console.WriteLine("Se resolverá para un tamaño de paso de 1, 0.4, 0.2, 0.02 y 0.002.");
            Console.WriteLine();

            foreach (double paso in pasos)
            {
                double resultadoEuler = Euler(xInicial, fInicial, paso);
                double resultadoRungeKutta = RungeKutta(xInicial, fInicial, paso);

                Console.WriteLine($"Tamaño de paso: {paso}");
                Console.WriteLine($"Método de Euler: {resultadoEuler}");
                Console.WriteLine($"Método de Runge-Kutta: {resultadoRungeKutta}");
                Console.WriteLine($"Diferencia entre los métodos: {Math.Abs(resultadoEuler - resultadoRungeKutta)}");
                Console.ReadLine();
            }
        }
        // Función que representa la ecuación diferencial df(x) / dx = -sin(x) + 5f(x) cos(x)
        static double Funcion(double x, double f)
        {
            return -Math.Sin(x) + 5 * f * Math.Cos(x);
        }

        // Método de Euler para resolver la ecuación diferencial
        static double Euler(double x, double f, double h)
        {
            return f + h * Funcion(x, f);
        }

        // Método de Runge-Kutta de cuarto orden para resolver la ecuación diferencial
        static double RungeKutta(double x, double f, double h)
        {
            double k1 = h * Funcion(x, f);
            double k2 = h * Funcion(x + 0.5 * h, f + 0.5 * k1);
            double k3 = h * Funcion(x + 0.5 * h, f + 0.5 * k2);
            double k4 = h * Funcion(x + h, f + k3);

            return f + (k1 + 2 * k2 + 2 * k3 + k4) / 6.0;
        }
    }
}

