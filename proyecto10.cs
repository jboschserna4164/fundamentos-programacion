using System;

namespace proyecto10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //desafio 02: calculo cuota moderadora            
            Console.WriteLine("Ingrese su salario");
            double salario = int.Parse(Console.ReadLine());

            //calcular el salario minimo mensual
            double salariominm = salario / 877803;
            Console.WriteLine(salariominm + " SMMLV");

            //calcular el salario minimo diario
            double salariomind = 877803 / 30;
            Console.WriteLine("El salario minimo diario es " + salariomind);

            

            if(salariominm >= 0 && salariominm < 2)
            {
                Console.WriteLine("Es tarifa A");
                Console.WriteLine("Cuota moderadora = el 11.7% de un salario mínimo diario legal vigente.");
                double cuota = salariomind * 0.117;
                Console.WriteLine("Cuota moderadora = " + cuota);

            }

            if (salariominm >= 2 && salariominm < 5)
            {
                Console.WriteLine("Es tarifa B");
                Console.WriteLine("Cuota moderadora = el 46.1% de un salario mínimo diario legal vigente.");
                double cuota = salariomind * 0.461;
                Console.WriteLine("Cuota moderadora = " + cuota);
            }

            if (salariominm >= 5)
            {
                Console.WriteLine("Es tarifa C");
                Console.WriteLine("Cuota moderadora = el 121.5% de un salario mínimo diario legal vigente.");
                double cuota = salariomind * 0.1215;
                Console.WriteLine("Cuota moderadora = " + cuota);
            }

            else if(salariominm < 0)
            {
                Console.WriteLine("Salario no no permitido");
            }

        }
    }
}
