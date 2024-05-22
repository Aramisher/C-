using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_6
{
    class Class1
    {
        static void Main()
        {
            double x = -4.0;
            double funcion, derivada, derivadaSegunda, nuevaRaiz;
            int ciclos = 0; // Variable que cuenta las iteraciones
            bool exit = false; // Variable booleana que indica si se ha encontrado la solución

            // Explicamos que hace el programa, esto es muy importante ya que no se necesita de ningun valor del usuario
            Console.WriteLine("Programa que buscara la raiz de la ecuación:");
            Console.WriteLine("y = -x^3 - x^2  + 13x + 30");
            Console.WriteLine("Se usará mas de 1 metodo en caso de ser necesario\n");

            // Método Newton-Raphson
            Console.WriteLine("Método Newton-Raphson:");
            while (ciclos < 100 && !exit)
            {
                funcion = -Math.Pow(x, 3) - Math.Pow(x, 2) + 13 * x + 30; // Evalúa la función en x
                derivada = -3 * Math.Pow(x, 2) - 2 * x + 13; // Evalúa la derivada de la función en x

                nuevaRaiz = x - funcion / derivada; // Calcula la nueva raíz estimada

                Console.WriteLine($"Ciclo {ciclos + 1}: x = {nuevaRaiz}"); // Imprime el valor de x en esta iteración

                // Si la función en la raíz estimada es cercana a cero, se ha encontrado la solución
                if (Math.Abs(funcion) < 0.0001)
                { 
                    exit = true;
                    Console.WriteLine("\nLa raiz de la función es: " + nuevaRaiz);
                }

                x = nuevaRaiz; // Actualiza el valor de x para la próxima iteración
                ciclos++; // Incrementa la variable de iteraciones
            }

            // Método de la secante
            if (!exit)
            {
                Console.WriteLine("Método de la secante:");
                double x1 = -4.0; // Variable que guarda la raiz anterior
                double x2 = -3.9; // Varibale que guarda la raiz actual

                while (ciclos < 100 && !exit)
                {
                    double y1 = -Math.Pow(x1, 3) - Math.Pow(x1, 2) + 13 * x1 + 30; // Evalúa la función en x1
                    double y2 = -Math.Pow(x2, 3) - Math.Pow(x2, 2) + 13 * x2 + 30; // Evalúa la función en x2
                    
                    derivadaSegunda = (y2 - y1) / (x2 - x1); // Calcula la aproximación de la derivada de la función
                    
                    nuevaRaiz = x2 - y2 / derivadaSegunda; // Calcula la nueva raíz estimada

                    Console.WriteLine($"Ciclo {ciclos} x = {nuevaRaiz}"); // Imprime el valor de x en esta iteración

                    if (Math.Abs(y2) < 0.0001)
                    { 
                        exit = true; // Si la función en la raíz estimada es cercana a cero, se ha encontrado la solución
                        Console.WriteLine("\nLa raiz de la función es: " + nuevaRaiz);
                    }

                    x1 = x2; // Actualiza los valores de x para la próxima iteración
                    x2 = nuevaRaiz; 

                    ciclos++; // Incrementa la variable de iteraciones
                }
            }

            // Método de bisección
            if (!exit)
            {
                Console.WriteLine("Método de bisección:");
                double a = -4.0;
                double b = -3.9;
                while (ciclos < 100 && !exit)
                {
                    double y_a = -Math.Pow(a, 3) - Math.Pow(a, 2) + 13 * a + 30; // evalúa la función en a
                    double y_b = -Math.Pow(b, 3) - Math.Pow(b, 2) + 13 * b + 30; // evalúa la función en b
                    
                    double c = (a + b) / 2; // calcula el punto medio entre a y b
                    
                    double y_c = -Math.Pow(c, 3) - Math.Pow(c, 2) + 13 * c + 30; // evalúa la función en c
                    
                    Console.WriteLine($"Ciclo {ciclos}: x = {c}"); // imprime el valor de x en esta iteración
                    
                    if (Math.Abs(y_c) < 0.0001)
                    { // si la función en la raíz estimada es cercana a cero, se ha encontrado la solución
                        exit = true;
                        Console.WriteLine("\nLa raiz de la función es: " + c);
                    }
                    if (y_a * y_c < 0)
                    { // la raíz está entre a y c
                        b = c; // actualiza el valor de b
                    }
                    else
                    { // la raíz está entre c y b
                        a = c; // actualiza el valor de a
                    }
                    ciclos++; // incrementa la variable de iteraciones
                }
            }

            if (!exit)
            {
                Console.WriteLine("No se encontró ninguna raíz en 100 ciclos.");
            }
            Console.ReadLine();
        }
    }
}
