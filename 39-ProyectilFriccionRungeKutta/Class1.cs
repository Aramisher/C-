using System;
using System.Collections.Generic;

namespace Evidencia_3
{
    class Program
    {
        const double gravedad = 9.81;
        const double velocidadInicial = 20.0;
        const double coeficienteFriccion = 0.1;
        const double pasoTiempo = 0.01;

        static void Main()
        {
            Console.WriteLine("Este programa calcula la posición y velocidad final de un proyectil lanzado en diferentes ángulos (10°, 30°, 45° y 90°) considerando la fricción del aire.");

            List<double> angulos = new List<double> { 10, 30, 45, 90 };

            double maxDistancia = 0;
            double anguloMaxDistancia = 0;

            foreach (double angulo in angulos)
            {
                double radianes = angulo * (Math.PI / 180.0);

                double posX = 0;
                double posY = 0;
                double velX = velocidadInicial * Math.Cos(radianes);
                double velY = velocidadInicial * Math.Sin(radianes);

                // Resuelve las ecuaciones diferenciales utilizando el método de Runge-Kutta de cuarto orden
                while (posY >= 0)
                {
                    double k1_vx, k1_vy, k1_x, k1_y;
                    double k2_vx, k2_vy, k2_x, k2_y;
                    double k3_vx, k3_vy, k3_x, k3_y;
                    double k4_vx, k4_vy, k4_x, k4_y;

                    // Primer paso
                    k1_x = velX;
                    k1_y = velY;
                    k1_vx = -coeficienteFriccion * velX * Math.Sqrt(velX * velX + velY * velY);
                    k1_vy = -gravedad - coeficienteFriccion * velY * Math.Sqrt(velX * velX + velY * velY);

                    // Segundo paso
                    k2_x = velX + 0.5 * pasoTiempo * k1_vx;
                    k2_y = velY + 0.5 * pasoTiempo * k1_vy;
                    k2_vx = -coeficienteFriccion * k2_x * Math.Sqrt(k2_x * k2_x + k2_y * k2_y);
                    k2_vy = -gravedad - coeficienteFriccion * k2_y * Math.Sqrt(k2_x * k2_x + k2_y * k2_y);

                    // Tercer paso
                    k3_x = velX + 0.5 * pasoTiempo * k2_vx;
                    k3_y = velY + 0.5 * pasoTiempo * k2_vy;
                    k3_vx = -coeficienteFriccion * k3_x * Math.Sqrt(k3_x * k3_x + k3_y * k3_y);
                    k3_vy = -gravedad - coeficienteFriccion * k3_y * Math.Sqrt(k3_x * k3_x + k3_y * k3_y);

                    // Cuarto paso
                    k4_x = velX + pasoTiempo * k3_vx;
                    k4_y = velY + pasoTiempo * k3_vy;
                    k4_vx = -coeficienteFriccion * k4_x * Math.Sqrt(k4_x * k4_x + k4_y * k4_y);
                    k4_vy = -gravedad - coeficienteFriccion * k4_y * Math.Sqrt(k4_x * k4_x + k4_y * k4_y);

                    // Actualiza posición y velocidad
                    posX += (1.0 / 6.0) * pasoTiempo * (k1_x + 2 * k2_x + 2 * k3_x + k4_x);
                    posY += (1.0 / 6.0) * pasoTiempo * (k1_y + 2 * k2_y + 2 * k3_y + k4_y);
                    velX += (1.0 / 6.0) * pasoTiempo * (k1_vx + 2 * k2_vx + 2 * k3_vx + k4_vx);
                    velY += (1.0 / 6.0) * pasoTiempo * (k1_vy + 2 * k2_vy + 2 * k3_vy + k4_vy);
                }

                Console.WriteLine($"\nÁngulo: {angulo}°");
                Console.WriteLine($"Posición final: ({posX}, {posY})");
                Console.WriteLine($"Velocidad final: ({velX}, {velY})");

                if (posX > maxDistancia)
                {
                    maxDistancia = posX;
                    anguloMaxDistancia = angulo;
                }
            }

            Console.WriteLine($"\nEl ángulo en el que el proyectil alcanza la mayor distancia es: {anguloMaxDistancia}° con una distancia de {maxDistancia} metros.");
            Console.ReadLine();
        }
    }
}
