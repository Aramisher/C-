using System;

class InterpolacionNewtonValoresIntermedios
{
    public static void Main()
    {
        double[] xValores = { -5, -3, -0.7, 0.25, 2.1, 6, 7.46, 19.1, 15.5 };
        double[] yValores = { 6, 5.3, 1.53, -2.7, 4, 9.1, 2.2, 3.5, 6.2 };
        double paso = 0.4;

        Console.WriteLine("Este programa calcula los valores intermedios entre x = -5 y x = 32 con un incremento de 0.4 utilizando el polinomio de Newton:");

        for (double x = -5; x <= 32; x += paso)
        {
            double y = Interpolacion(xValores, yValores, x);
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }

        Console.ReadLine();
    }
    // Método para calcular las diferencias divididas
    // Utiliza los valores x y y para calcular las diferencias divididas
    static double[] DiferenciasDivididas(double[] xValores, double[] yValores)
    {
        int n = xValores.Length;
        double[] diferencias = new double[n];

        for (int i = 0; i < n; i++)
            diferencias[i] = yValores[i];

        // Calcular las diferencias divididas
        for (int i = 1; i < n; i++)
            for (int j = n - 1; j >= i; j--)
                diferencias[j] = (diferencias[j] - diferencias[j - 1]) / (xValores[j] - xValores[j - i]);

        return diferencias;
    }

    // Método para calcular la interpolación utilizando el polinomio de Newton
    // Utiliza los valores x, y y un punto x dado para calcular el valor interpolado
    static double Interpolacion(double[] xValores, double[] yValores, double x)
    {
        int n = xValores.Length;
        double[] diferencias = DiferenciasDivididas(xValores, yValores);
        double resultado = diferencias[0];

        // Calcular el polinomio de Newton
        for (int i = 1; i < n; i++)
        {
            double termino = diferencias[i];

            for (int j = 0; j < i; j++)
                termino *= (x - xValores[j]);

            resultado += termino;
        }
        return resultado;
    }
}

