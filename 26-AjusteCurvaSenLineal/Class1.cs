using System;
using MathNet.Numerics.LinearRegression;
using MathNet.Numerics.LinearAlgebra;

class AjusteCurva
{
    static void Main()
    {

        // Datos de entrada
        double[] tiempos = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        double[] valoresFt = { 7.2074, 10.5465, 9.7056, 8.2160, 10.2054, 16.6029, 24.2849, 28.9468, 29.0606, 27.2799 };

        // Explicamos lo que hace el programa
        Console.WriteLine("Este programa ajustará la curva de una tabla de datos en base a la siguiente ecuación: \nf(t) = x1t + x2 sen(t)\n");

        // Crear la matriz de diseño
        double[][] matrizDiseno = new double[tiempos.Length][];

        for (int i = 0; i < tiempos.Length; i++)
        {
            matrizDiseno[i] = new double[2];
            matrizDiseno[i][0] = tiempos[i]; // t
            matrizDiseno[i][1] = Math.Sin(tiempos[i]); // sen(t)
        }
        // Convertir la matriz de diseño a una matriz de MathNet
        var matrizMathNet = Matrix<double>.Build.DenseOfRowArrays(matrizDiseno);

        // Calcular los coeficientes x1 y x2 usando el método de mínimos cuadrados
        double[] coeficientes = MultipleRegression.NormalEquations(matrizMathNet, Vector<double>.Build.Dense(valoresFt)).ToArray();

        // Extraer x1 y x2 de los coeficientes
        double x1 = coeficientes[0];
        double x2 = coeficientes[1];

        // Imprimir x1 y x2
        Console.WriteLine("x1: " + x1);
        Console.WriteLine("x2: " + x2);

        Console.ReadKey();

        // Imprimir los valores de f(t) ajustados utilizando x1 y x2
        Console.WriteLine("\nValores ajustados de f(t):");
        for (int i = 0; i < tiempos.Length; i++)
        {
            double valorAjustado = x1 * tiempos[i] + x2 * Math.Sin(tiempos[i]);
            Console.WriteLine("f(" + tiempos[i] + ") = " + valorAjustado);
        }
    }
}

