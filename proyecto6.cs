using System;

namespace proyecto6
{
    class Program
    {
        static void Main(string[] args)
        {
            //desafio 01-04, tenemos d, b, y
            double d = 36.87;
            double b = 19.44;
            double y = 2;

            //hallar e
            double e = 180 - d - b;

            //hallar c y convertirla de grados a radianes
            double c = 180 - e;
            double c1 = (c * Math.PI) / 180;

            //hallar z
            double z = y * Math.Tan(c1);
            Console.WriteLine("z = " + z);

        }
    }
}
