using System;

class InterpolacionLagrange
{
    public static void Main()
    {
        double[] xValores = { -5, -3, -0.7, 0.25, 2.1, 6, 7.46, 19.1, 15.5 };
        double[] yValores = { 6, 5.3, 1.53, -2.7, 4, 9.1, 2.2, 3.5, 6.2 };
        double x = 5.234;

        // Este programa calcula la interpolación de Lagrange en x = 5.234
        Console.WriteLine("Este programa calcula la interpolación de Lagrange en x = {0}:", x);
        Console.WriteLine("Resultado: {0}", Interpolacion(xValores, yValores, x));
        Console.ReadLine();
    }
    // Método para calcular la interpolación de Lagrange
    // Utiliza los valores x, y y un punto x dado para calcular el valor interpolado
    static double Interpolacion(double[] xValores, double[] yValores, double x)
    {
        double resultado = 0;
        int n = xValores.Length;

        // Para cada punto en los datos
        for (int i = 0; i < n; i++)
        {
            double termino = yValores[i];

            // Multiplicar los términos correspondientes
            for (int j = 0; j < n; j++)
            {
                if (j != i)
                    termino *= (x - xValores[j]) / (xValores[i] - xValores[j]);
            }
            resultado += termino;
        }
        return resultado;
    }
}

