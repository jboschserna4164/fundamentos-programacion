using System;

namespace proyecto1
{
	class Program
	{
		static void Main(string[] args)
		{
			//ejercio 02-01 conozco Y y Z			
			double y = 2;
			double z = 3;

			//hallar T por medio del teorema de pitagoras
			double t = Math.Sqrt((y * y) + (z * z));
			Console.WriteLine("t = " + t);

			//hallar a y c
			double a = Math.Asin(y / t);
			double c = Math.Asin(z / t);

			//pasar a y c de radianes a grados
			double a1 = (a * 180) / Math.PI;
			double c1 = (c * 180) / Math.PI;
			Console.WriteLine("a = " + a1 );
			Console.WriteLine("c = " + c1 );
		}
	}
}
