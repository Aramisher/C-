using System;

namespace MetodoRungeKutta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imprimir la descripción del programa
            Console.WriteLine("Este programa resuelve la ecuación diferencial df(x)/dx + x^2 f(x) = sin(x) + cos(f(x)) utilizando el método de Runge-Kutta.");
            Console.WriteLine("Condiciones iniciales: x = 0, f(x) = -2.");
            Console.WriteLine("Encuentra el valor de f(x) cuando x = 5.");
            Console.WriteLine("Tamaño de paso: 0.001.");
            Console.WriteLine();

            // Definir variables en español
            double xInicial = 0;
            double yInicial = -2;
            double xFinal = 5;
            double tamañoPaso = 0.001;

            // Función para calcular la derivada
            Func<double, double, double> derivada = (x, y) => (Math.Sin(x) + Math.Cos(y) - x * x * y);

            // Método de Runge-Kutta
            double xActual = xInicial;
            double yActual = yInicial;

            while (xActual < xFinal)
            {
                double k1 = tamañoPaso * derivada(xActual, yActual);
                double k2 = tamañoPaso * derivada(xActual + tamañoPaso / 2, yActual + k1 / 2);
                double k3 = tamañoPaso * derivada(xActual + tamañoPaso / 2, yActual + k2 / 2);
                double k4 = tamañoPaso * derivada(xActual + tamañoPaso, yActual + k3);

                yActual += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                xActual += tamañoPaso;
            }

            // Imprimir el resultado
            Console.WriteLine($"El valor de f(x) cuando x = {xFinal} es: {yActual}");
            Console.ReadLine();
        }
    }
}
