using System;

namespace proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {
			//ejercio 02-02 conozco T y A			
			double t = 3.61;
			double a = 33.69;

			//convertir A a radianes
			double a1 = a * Math.PI / 180;

			//hallar Y
			double y = t * Math.Sin(a1);
			Console.WriteLine("y = " + y);

			//hallamos Z por el teorema de pitagoras
			double z = Math.Sqrt((t * t) - (y * y));
			Console.WriteLine("z = " + z);

			//hallar C
			double c = Math.Asin(z / t);			

			//pasar C a grados
			double c1 = (c * 180) / Math.PI;
			Console.WriteLine("c = " + c1);

		}
    }
}
