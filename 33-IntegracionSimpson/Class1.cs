using System;

namespace Tarea_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imprimir la descripción del programa
            Console.WriteLine("Este programa integra la función (e^z)^-2 utilizando la regla de Simpson.");

            // Solicitar los límites de integración
            Console.Write("Ingrese el límite inferior: ");
            double limiteInferior = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el límite superior: ");
            double limiteSuperior = double.Parse(Console.ReadLine());

            // Asegurar que el límite superior sea mayor que el límite inferior
            if (limiteSuperior < limiteInferior)
            {
                double temp = limiteSuperior;
                limiteSuperior = limiteInferior;
                limiteInferior = temp;
            }

            // Solicitar el número de partes en las que se desea dividir la integral
            Console.Write("Ingrese el número de partes: ");
            int partes = int.Parse(Console.ReadLine());

            // Calcular la integral usando la regla de Simpson
            double resultado = ReglaSimpson(limiteInferior, limiteSuperior, partes);

            // Imprimir el resultado
            Console.WriteLine($"El resultado de la integral es: {resultado}");
            Console.ReadLine();
        }
        // Método para evaluar la función (e^z)^-2
        static double Funcion(double z)
        {
            return Math.Pow(Math.Exp(z), -2);
        }

        // Método para calcular la integral utilizando la regla de Simpson
        static double ReglaSimpson(double limiteInferior, double limiteSuperior, int partes)
        {
            double suma = 0.0;
            double h = (limiteSuperior - limiteInferior) / partes;

            for (int i = 0; i <= partes; i++)
            {
                double z = limiteInferior + i * h;
                double factor = (i == 0 || i == partes) ? 1 : (i % 2 == 0) ? 2 : 4;
                suma += factor * Funcion(z);
            }

            return suma * (h / 3);
        }
    }
}

