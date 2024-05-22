using System;

namespace Actividad_8
{
    class Class1
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            double x = 1, y = 1, z = 1;
            double funcionX = 0, funcionY = 0;
            double dFx_dx = 0, dFx_dy = 0, dFx_dz = 0;
            double dFy_dx = 0, dFy_dy = 0, dFy_dz = 0;

            double e = Math.E;
            double precision = 0.00001; // Error permitido en la solución

            int maxCiclos = 100; // Número máximo de iteraciones permitido
            int ciclos = 0; // Contador de iteraciones

            // Bucle de iteración
            do
            {
                // Cálculo de las funciones f(x,y,z) y sus derivadas parciales
                funcionX = Math.Pow(e, x) + Math.Pow(2, -y) + 2 * Math.Cos(z) - 6;
                funcionY = Math.Pow(x, 2) + 10 * Math.Cos(y) + z + 3;

                dFx_dx = Math.Pow(e, x);
                dFx_dy = -Math.Log(2) * Math.Pow(2, -y);
                dFx_dz = -2 * Math.Sin(z);

                dFy_dx = 2 * x;
                dFy_dy = -10 * Math.Sin(y);
                dFy_dz = 1;

                
                double det = dFx_dx * dFy_dy - dFx_dy * dFy_dx;

                if (Math.Abs(det) < 1e-10)
                {
                    Console.WriteLine("El determinante de la matriz jacobiana es cercano a cero. No se puede continuar con el método de Newton-Raphson.");
                    break;
                }
                else
                {
                    // Cálculo de los nuevos valores de x, y, z mediante el método de Newton-Raphson
                    double cambioX = (-funcionX * dFy_dy + funcionY * dFx_dy) / det;
                    double cambioY = (-funcionY * dFx_dx + funcionX * dFy_dx) / det;

                    x += cambioX;
                    y += cambioY;
                }

                // Actualización del contador de iteraciones
                ciclos++;

            } while ((Math.Abs(funcionX) > precision || Math.Abs(funcionY) > precision) && ciclos < maxCiclos);

            // Impresión de los resultados
            if (ciclos >= maxCiclos)
            {
                Console.WriteLine("No se ha encontrado una solución dentro del número máximo de iteraciones permitido.");
            }
            else
            {
                Console.WriteLine("Una solución aproximada del sistema de ecuaciones es:");
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.WriteLine("z = " + z);
                Console.WriteLine("Número de ciclos " + ciclos);
            }

            Console.ReadKey();
        }
    }
}
