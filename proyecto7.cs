using System;

namespace proyecto7
{
    class Program
    {
        static void Main(string[] args)
        {
            //desafio 01-04, tenemos w, d, x
            double w = 5;
            double d = 36.87;
            double x = 2;

            //pasamos d a radianes para despues hallar t
            double d1 = (36.87 * Math.PI) / 180;

            //hallar t
            double t = Math.Sqrt(((w * w) + (x * x)) - ((2 * w * x ) * Math.Cos(d1)));
             
            //hallar b y convertirla en grados
            double b = (x * Math.Sin(d1)) / t;
            double b1 = Math.Asin(b);
            double b2 = (b1 * 180) / Math.PI;

            //hallar e
            double e = 180 - d - b2;

            //hallar c y convertila de gradoa radianes para hallar y
            double c = 180 - e;
            double c1 = (c * Math.PI) / 180;

            //hallar y
            double y = t * Math.Cos(c1);
            Console.WriteLine("y = " + y);
        }
    }
}
