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

            double salariomin = salario / 877803;
            Console.WriteLine(salariomin + " SMMLV");

            if(salariomin >= 0 && salariomin < 2)
            {
                Console.WriteLine("Es tarifa A");
                Console.WriteLine("Cuota moderadora = el 11.7% de un salario mínimo diario legal vigente.");
            }

            if (salariomin >= 2 && salariomin < 5)
            {
                Console.WriteLine("Es tarifa B");
                Console.WriteLine("Cuota moderadora = el 46.1% de un salario mínimo diario legal vigente.");
            }

            if (salariomin >= 5)
            {
                Console.WriteLine("Es tarifa C");
                Console.WriteLine("Cuota moderadora = el 121.5% de un salario mínimo diario legal vigente.");
            }

            else if(salariomin < 0)
            {
                Console.WriteLine("Salario no no permitido");
            }

        }
    }
}
