using System;

namespace proyecto_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //desafio 01-04, tenemos w, t, c
            double w = 5;
            double t = 3.61;
            double c = 56.31;

            //convertir c a radianes y hallar z
            double c1 = (c * Math.PI) / 180;
            double z = t * Math.Sin(c1);

            //hallar y 
            double y = Math.Sqrt((t * t) - (z * z));

            //hallar x
            double x = Math.Sqrt((w * w) - (z * z)) - y;
            Console.WriteLine("x = " + x);
        }
    }
}
