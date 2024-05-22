using System;

namespace Integracion
{
    class Tarea_10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integración numérica de la función (e^z)^-2");

            // Solicitar al usuario los límites de integración
            Console.WriteLine("Ingrese el primer límite de integración:");
            double limite1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo límite de integración:");
            double limite2 = double.Parse(Console.ReadLine());

            // Identificar el límite superior e inferior
            double limiteInferior = Math.Min(limite1, limite2);
            double limiteSuperior = Math.Max(limite1, limite2);

            // Definir el número de partes (trapecios) para la integración
            int partes = 9500;

            Console.WriteLine($"Se utilizarán {partes} trapecios para la integración.");

            // Realizar la integración y mostrar el resultado
            double resultado = IntegracionTrapecio(limiteInferior, limiteSuperior, partes);

            Console.WriteLine($"La integral de la función (e^z)^-2 entre {limiteInferior} y {limiteSuperior} es: {resultado}");
            Console.ReadLine();
        }
        // Función que define la función matemática (e^z)^-2
        static double Funcion(double x)
        {
            return Math.Pow(Math.Exp(x), -2);
        }

        // Método que realiza la integración utilizando la regla del trapecio
        static double IntegracionTrapecio(double limiteInferior, double limiteSuperior, int partes)
        {
            double tamañoPaso = (limiteSuperior - limiteInferior) / partes;
            double suma = 0.0;
            double x = limiteInferior;

            // Realizar la suma de los trapecios
            for (int i = 1; i <= partes; i++)
            {
                suma += (Funcion(x) + Funcion(x + tamañoPaso)) / 2 * tamañoPaso;
                x += tamañoPaso;
            }

            return suma;
        }
    }
}
