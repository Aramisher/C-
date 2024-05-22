using System;

namespace InterpolacionLagrange
{
    class Program
    {
        static void Main(string[] args)
        {
            // Le indicamos al usuario lo que hara el programa
            Console.WriteLine("Este programa realiza la interpolación de datos utilizando el método de Lagrange.");
            Console.WriteLine("A continuación, se te pedirá que ingreses una serie de puntos (x, y).");
            Console.WriteLine("Luego, se te pedirá un punto de interpolación y se calculará el valor interpolado en ese punto.");

            // Declarar la variable que almacenará la cantidad de pares de datos
            int n;
            // Preguntar al usuario cuántos pares de datos quiere introducir
            Console.Write("¿Cuántos pares de datos quiere introducir? ");
            n = int.Parse(Console.ReadLine());

            // Crear dos arrays para almacenar los valores de x e y
            double[] x = new double[n];
            double[] y = new double[n];

            // Solicitar al usuario los valores de x
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduzca el valor de x[{i}]: ");
                x[i] = double.Parse(Console.ReadLine());
            }

            // Solicitar al usuario los valores de y
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduzca el valor de y[{i}]: ");
                y[i] = double.Parse(Console.ReadLine());
            }

            // Preguntar al usuario el punto en el que se va a obtener la interpolación
            Console.Write("Ingrese el punto en el que se va a obtener la interpolación: ");
            double puntoInterpolacion = double.Parse(Console.ReadLine());

            // Calcular el resultado de la interpolación utilizando el método de Lagrange
            double resultado = InterpolacionLagrange(x, y, puntoInterpolacion);

            // Mostrar el resultado de la interpolación
            Console.WriteLine($"El resultado de la interpolación en el punto {puntoInterpolacion} es: {resultado}");
            Console.ReadLine();
        }

        // Método que implementa la interpolación de Lagrange
        static double InterpolacionLagrange(double[] x, double[] y, double puntoInterpolacion)
        {
            // Obtener la cantidad de puntos en los arrays x e y
            int n = x.Length;
            // Inicializar la variable que almacenará el resultado de la interpolación
            double resultado = 0;

            // Bucle para recorrer los puntos y calcular los coeficientes de Lagrange
            for (int i = 0; i < n; i++)
            {
                // Inicializar el coeficiente de Lagrange para el punto actual
                double L = 1;
                // Calcular el coeficiente de Lagrange para el punto actual
                for (int j = 0; j < n; j++)
                {
                    // Evitar la división por cero cuando i == j
                    if (i != j)
                    {
                        // Calcular el coeficiente de Lagrange y acumularlo en L
                        L *= (puntoInterpolacion - x[j]) / (x[i] - x[j]);
                    }
                }
                // Calcular el valor interpolado y acumularlo en el resultado
                resultado += y[i] * L;
            }

            // Retornar el resultado de la interpolación
            return resultado;
        }
    }
}

