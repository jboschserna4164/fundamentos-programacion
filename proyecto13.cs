using System;

namespace proyecto13
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedimos al usuario a,b y c
            Console.WriteLine("Ingrese a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese c");
            double c = double.Parse(Console.ReadLine());

            double discriminante = Math.Sqrt((b * b) - (4 * a * c));

            double solucion = (-b + discriminante) / (2*a);
            double solucion1 = (-b - discriminante) / (2 * a);

            if(discriminante == 0)
            {
                Console.WriteLine(" X = " + solucion1);
            }

            if(discriminante > 0)
            {
                Console.WriteLine("Hay 2 tipos de solucion = " + "X1=" + solucion + " X2=" + solucion1);
            }

            if(discriminante < 0)
            {
                Console.WriteLine("No es posible calcular la solucion");
            }

        }
    }
}
