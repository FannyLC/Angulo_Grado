// ID: Fanny Luna

using System;

namespace TipoDeAngulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            double angulo;

            // Solicitar al usuario el ángulo en grados
            Console.WriteLine("Ingrese el ángulo en grados:");
            angulo = Convert.ToDouble(Console.ReadLine());

            // Evaluar el tipo de ángulo
            if (angulo < 90)
            {
                Console.WriteLine("El ángulo es agudo.");
            }
            else if (angulo == 90)
            {
                Console.WriteLine("El ángulo es recto.");
            }
            else
            {
                Console.WriteLine("El ángulo es obtuso.");
            }

            // Mantener la consola abierta
            Console.WriteLine("Presione cualquier tecla para cerrar...");
            Console.ReadKey();
        }
    }
}
