using System;
using MathNet.Numerics;
using MathNet.Numerics.LinearRegression;

namespace CurveFitting
{
    class Tarea_8
    {
        static void Main(string[] args)
        {
            // Datos de tiempo y función
            double[] tiempo = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] funcion = new double[] { 17.2074, 9.5465, 9.7056, 3.2160, 10.54, 1.6029, 24.2948, 25.9468, 30.0606, 17.2799 };

            Console.WriteLine("Este programa ajusta la curva de la tabla de datos en base a 2 ecuaciones diferentes");

            // Ajuste de grado 2
            double[] coeficiente2 = Ajuste(tiempo, funcion, 2);

            Console.WriteLine("Coeficientes del polinomio de grado 2: ");

            for (int i = 0; i < coeficiente2.Length; i++)
            {
                Console.WriteLine($"a{i}: {coeficiente2[i]}");
            }

            // Ajuste de grado 3
            double[] coeficientesPolinomioGrado3 = Ajuste(tiempo, funcion, 3);

            Console.WriteLine("\nCoeficientes del polinomio de grado 3: ");
            for (int i = 0; i < coeficientesPolinomioGrado3.Length; i++)
            {
                Console.WriteLine($"a{i}: {coeficientesPolinomioGrado3[i]}");
            }

            Console.ReadKey();
        }

        // Función para realizar el ajuste polinomial usando Math.NET
        static double[] Ajuste(double[] x, double[] y, int grado)
        {
            // Crear matriz de diseño para el polinomio deseado
            int n = x.Length;
            var matrizDiseno = new double[n][];
            for (int i = 0; i < n; i++)
            {
                matrizDiseno[i] = new double[grado + 1];
                for (int j = 0; j <= grado; j++)
                {
                    matrizDiseno[i][j] = Math.Pow(x[i], j);
                }
            }

            // Calcular coeficientes de ajuste por mínimos cuadrados
            double[] coeficientes = MultipleRegression.NormalEquations(matrizDiseno, y);

            return coeficientes;
        }
    }
}
