using System;

namespace MetodoEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imprimir la descripción del programa
            Console.WriteLine("Este programa resuelve la ecuación diferencial x(df(x)/dy) + f(x) = x utilizando el método de Euler.");
            Console.WriteLine("Condiciones iniciales: x = 0, f(x) = 4.");
            Console.WriteLine("Encuentra el valor de f(x) cuando x = 6.");
            Console.WriteLine("Tamaño de paso: 0.001.");
            Console.WriteLine();

            // Definir variables en español
            double xInicial = 0;
            double yInicial = 4;
            double xFinal = 6;
            double tamañoPaso = 0.001;

            // Función para calcular la derivada
            Func<double, double, double> derivada = (x, y) => x == 0 ? 0 : (x - y) / x;

            // Método de Euler
            double xActual = xInicial;
            double yActual = yInicial;

            while (xActual < xFinal)
            {
                yActual += tamañoPaso * derivada(xActual, yActual);
                xActual += tamañoPaso;
            }

            // Imprimir el resultado
            Console.WriteLine($"El valor de f(x) cuando x = {xFinal} es: {yActual}");
            Console.ReadLine();
        }
    }
}
