using System;

namespace proyecto3
{
    class Program
    {
        static void Main(string[] args)
        {
			//ejercio 02-03 conozco C y Z 			
			double c = 56.31;
			double z = 3;

			//convertir C a radianes
			double c1 = c * Math.PI / 180;


			//hallar T 
			double t = z / Math.Sin(c1);
			Console.WriteLine("t = " + t);

			//hallar Y por el teorema de pitagoras
			double y = Math.Sqrt((t * t) - (z * z));
			Console.WriteLine("z = " + z);

			//hallar A
			double a = Math.Asin(y / t);


			//Convertir A a grados
			double a1 = a * 180 / Math.PI;
            Console.WriteLine("a = " + a1);
		}
    }
}
