using System;

namespace ResolucionEcuacionesNoLineales
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x0 = new double[] { 1, 1, 1 };
            double tolerancia = 1e-6;
            int ciclos = 100;

            double[] solucion = NewtonRaphson(x0, tolerancia, ciclos);

            Console.WriteLine("Programa que resolverá el siguiente sistema de ecuaciones");
            Console.WriteLine("x1 = x3 sen (x1 + x2) \nx1 = e ^ (x1 + x3) \nx1 x2 = (x1 x3) - (x2 x3)");
            Console.WriteLine("\nSolución del sistema de ecuaciones:");
            Console.WriteLine($"x1 = {solucion[0]}");
            Console.WriteLine($"x2 = {solucion[1]}");
            Console.WriteLine($"x3 = {solucion[2]}");
            Console.ReadLine();
        }

        // Función que representa el sistema de ecuaciones no lineales
        static double[] Func(double[] x)
        {
            double[] resultado = new double[3];
            resultado[0] = x[2] * Math.Sin(x[0] + x[1]) - x[0];
            resultado[1] = Math.Exp(x[0] + x[2]) - x[0];
            resultado[2] = (x[0] * x[1]) - (x[1] * x[2]) - (x[0] * x[2]);
            return resultado;
        }

        // Función para calcular el jacobiano utilizando diferencias finitas
        static double[,] Jacobiano(double[] x, double h)
        {
            int n = x.Length;
            double[,] J = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double[] xPlusH = (double[])x.Clone();
                    xPlusH[j] += h;

                    double[] xMinusH = (double[])x.Clone();
                    xMinusH[j] -= h;

                    double FPlusH = Func(xPlusH)[i];
                    double FMinusH = Func(xMinusH)[i];
                    J[i, j] = (FPlusH - FMinusH) / (2 * h);
                }
            }

            return J;
        }

        // Función para multiplicar una matriz por un vector
        static double[] MatrizPorVector(double[,] matriz, double[] vector)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double[] resultado = new double[filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    resultado[i] += matriz[i, j] * vector[j];
                }
            }

            return resultado;
        }

        // Función para resolver un sistema de ecuaciones lineales utilizando la eliminación de Gauss
        static double[] ResuelveSistemaEcuaciones(double[,] matriz, double[] vector)
        {
            int n = matriz.GetLength(0);
            double[] solucion = new double[n];

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    double factor = matriz[j, i] / matriz[i, i];
                    for (int k = i; k < n; k++)
                    {
                        matriz[j, k] -= factor * matriz[i, k];
                    }
                    vector[j] -= factor * vector[i];
                }
            }

            solucion[n - 1] = vector[n - 1] / matriz[n - 1, n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                double sum = vector[i];

                for (int j = i + 1; j < n; j++)
                {
                    sum -= matriz[i, j] * solucion[j];
                }

                solucion[i] = sum / matriz[i, i];
            }

            return solucion;
        }

        static double[] NewtonRaphson(double[] x0, double tolerancia, int ciclos)
        {
            int iter = 0;
            double[] x = (double[])x0.Clone();

            while (iter < ciclos)
            {
                double[] Fx = Func(x);
                double norma = 0;

                for (int i = 0; i < Fx.Length; i++)
                {
                    norma += Fx[i] * Fx[i];
                }

                if (Math.Sqrt(norma) < tolerancia)
                {
                    break;
                }

                double[,] Jx = Jacobiano(x, 1e-5);
                double[] delta = ResuelveSistemaEcuaciones(Jx, Fx);

                for (int i = 0; i < x.Length; i++)
                {
                    x[i] -= delta[i];
                }

                iter++;
            }

            return x;
        }


    }
}