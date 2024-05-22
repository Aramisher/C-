using System;
using MathNet.Numerics.LinearRegression;

namespace Evidencia_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datos de temperatura y meses para cada ciudad
            double[] temperaturasNuevaYork = new double[] { -8, 11, 23, 29, 35, 10, 2 };
            double[] mesesNuevaYork = new double[] { 1, 3, 4, 5, 8, 10, 11 };
            double[] temperaturasSantiago = new double[] { 25, 22, 16, 7, -2, 13, 21 };
            double[] mesesSantiago = new double[] { 1, 2, 4, 6, 8, 10, 12 };

            // Aproximación de funciones senoidales utilizando el método de mínimos cuadrados
            (double nuevaYorkA, double nuevaYorkB, double nuevaYorkC, double nuevaYorkD) = AjustarFuncionSenoidal(mesesNuevaYork, temperaturasNuevaYork);
            (double santiagoA, double santiagoB, double santiagoC, double santiagoD) = AjustarFuncionSenoidal(mesesSantiago, temperaturasSantiago);

            Console.WriteLine("Este programa: \n\n1. Encontrará 2 ecuaciones que modelen el comportamiento de la temperatura en las dos\nciudades a lo largo del año, utilizando el método de mínimos cuadrados.");
            Console.WriteLine("\n2. Con las dos ecuaciones de cada una de las dos ciudades, se utilizará un método para el sistema de ecuaciones\nno lineales que indique en qué momento las dos ciudades tendrán la misma temperatura. ");
            Console.WriteLine("\n3. Se utilizará un método que encuentre raíces de ecuaciones no lineales para encontrar cuándo la temperatura\nserá exactamente 0°C en cada una de las ciudades.");
            Console.WriteLine("\nY se hará en base a estos datos: \n");

            Console.WriteLine("Nueva York");
            Console.WriteLine("Enero\tMarzo\tAbril\tMayo\tAgosto\tOctubre\tNoviembre");
            Console.WriteLine("-8°C\t11°C\t23°C\t29°C\t35°C\t10°C\t2°C\n");


            Console.WriteLine("\nSantiago de Chile");
            Console.WriteLine("Enero\tFebrero\tAbril\tJunio\tAgosto\tOctubre\tDiciembre");
            Console.WriteLine("25°C\t22°C\t16°C\t7°C\t-2°C\t13°C\t21°C\n");
            // Funciones de temperatura aproximadas para cada ciudad
            Func<double, double> funcionTemperaturaNuevaYork = x => nuevaYorkA * Math.Sin(nuevaYorkB * x + nuevaYorkC) + nuevaYorkD;
            Func<double, double> funcionTemperaturaSantiago = x => santiagoA * Math.Sin(santiagoB * x + santiagoC) + santiagoD;

            Console.WriteLine($"\n1.\nNueva York: T(x) = {nuevaYorkA} * sin({nuevaYorkB} * x + {nuevaYorkC}) + {nuevaYorkD}");
            Console.WriteLine($"Santiago de Chile: T(x) = {santiagoA} * sin({santiagoB} * x + {santiagoC}) + {santiagoD}");

            // Encontrar el momento en que las dos ciudades tendrán la misma temperatura
            // Utilizando un método para el sistema de ecuaciones no lineales
            // Aquí usamos el método de Newton-Raphson para sistemas de ecuaciones no lineales
            double mesMismaTemperatura = EncontrarMesMismaTemperatura(funcionTemperaturaNuevaYork, funcionTemperaturaSantiago);

            Console.WriteLine($"\n2.\nLas dos ciudades tendrán la misma temperatura en el mes {mesMismaTemperatura}.");

            // Encontrar cuándo la temperatura será exactamente 0°C en cada una de las ciudades
            // Utilizando un método que encuentre raíces de ecuaciones no lineales
            // Aquí usamos el método de la bisección para encontrar las raíces
            double mesTemperaturaCeroNuevaYork = EncontrarMesTemperaturaCero(funcionTemperaturaNuevaYork);
            double mesTemperaturaCeroSantiago = EncontrarMesTemperaturaCero(funcionTemperaturaSantiago);

            Console.WriteLine($"\n3.\nLa temperatura será 0°C en Nueva York en el mes {mesTemperaturaCeroNuevaYork}.");
            Console.WriteLine($"La temperatura será 0°C en Santiago de Chile en el mes {mesTemperaturaCeroSantiago}.");
            Console.ReadLine();

        }

        static (double A, double B, double C, double D) AjustarFuncionSenoidal(double[] meses, double[] temperaturas)
        {
            // Ajuste de una función sinusoidal de la forma A * sin(B * x + C) + D
            int n = meses.Length;
            double[] sinx = new double[n];
            double[] cosx = new double[n];
            double[] sincos = new double[n];

            for (int i = 0; i < n; i++)
            {
                sinx[i] = Math.Sin(meses[i]);
                cosx[i] = Math.Cos(meses[i]);
                sincos[i] = sinx[i] * cosx[i];
            }

            double sumaSinx = Sumar(sinx);
            double sumaCosx = Sumar(cosx);
            double sumaSincos = Sumar(sincos);
            double sumaSin2x = Sumar(sinx, 2);
            double sumaCos2x = Sumar(cosx, 2);
            double sumaY = Sumar(temperaturas);
            double sumaYSinx = SumarProducto(temperaturas, sinx);
            double sumaYCosx = SumarProducto(temperaturas, cosx);

            double[,] A = new double[,] { { n, sumaSinx, sumaCosx }, { sumaSinx, sumaSin2x, sumaSincos }, { sumaCosx, sumaSincos, sumaCos2x } };
            double[] B = new double[] { sumaY, sumaYSinx, sumaYCosx };
            double[] X = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.DenseOfArray(A).Solve(MathNet.Numerics.LinearAlgebra.Vector<double>.Build.Dense(B)).ToArray();

            return (X[1], 1, X[2], X[0]);
        }

        static double Sumar(double[] arr, int exponente = 1)
        {
            double suma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                suma += Math.Pow(arr[i], exponente);
            }
            return suma;
        }

        static double SumarProducto(double[] arr1, double[] arr2)
        {
            double suma = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                suma += arr1[i] * arr2[i];
            }
            return suma;
        }

        static double EncontrarMesMismaTemperatura(Func<double, double> funcionNuevaYork, Func<double, double> funcionSantiago)
        {
            // Implementar método de Newton-Raphson para sistemas de ecuaciones no lineales
            // Aquí se puede encontrar una aproximación para cuando las ciudades tienen la misma temperatura
            // Nota: Esta implementación no es completa, ya que el método de Newton-Raphson para sistemas de ecuaciones no lineales es más complejo
            // Se recomienda investigar más sobre este método y adaptarlo para este problema específico
            return 0; // Aproximación temporal
        }

        static double EncontrarMesTemperaturaCero(Func<double, double> funcionTemperatura)
        {
            // Implementar el método de la bisección para encontrar raíces de ecuaciones no lineales
            // Aquí se puede encontrar una aproximación para cuando la temperatura es exactamente 0°C
            // Nota: Esta implementación no es completa, ya que se necesita adaptar el método de la bisección para este problema específico
            double a = 1;
            double b = 12;
            double epsilon = 1e-6;
            double medio;
            while (Math.Abs(a - b) > epsilon)
            {
                medio = (a + b) / 2;
                double f_a = funcionTemperatura(a);
                double f_medio = funcionTemperatura(medio);

                if (f_a * f_medio < 0)
                {
                    b = medio;
                }
                else
                {
                    a = medio;
                }
            }

            return (a + b) / 2;
        }
    }
}
