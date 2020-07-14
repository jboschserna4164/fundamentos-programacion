using System;

namespace proyecto5
{
    class Program
    {
        static void Main(string[] args)
        {
            //desafio 01-04, solo conocemos b, z, y
            double b = 19.44;
            double z = 3;
            double y = 2;

            //hallamos t
            double t = Math.Sqrt((3 * 3) + (2 * 2));

            //hallamos c
            double c = Math.Asin(z / t);            
                       
            //pasamos c a grados
            double c1 = (c * 180) / Math.PI;           
            
            //hallamos e
            double e = 180 - c1;

            //hallamos d
            double d = 180 - e - b;

            //pasamos b y d de grados en radianes
            double b1 = (b * Math.PI) / 180;
            double d1 = (d * Math.PI) / 180;

            //hallamos x
            double x = (Math.Sin(b1) * t) / Math.Sin(d1);
            Console.WriteLine("x = " + x);



        }
    }
}
