using System;

namespace proyecto10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //desafio 02: calculo cuota moderadora            
            Console.WriteLine("Ingrese el numero de salarios minimos que gana");
            int salario = int.Parse(Console.ReadLine());

            if(salario >= 0 && salario < 2)
            {
                Console.WriteLine("Es tarifa A");
                Console.WriteLine("Cuota moderadora = el 11.7% de un salario mínimo diario legal vigente.");
            }

            if (salario >= 2 && salario < 5)
            {
                Console.WriteLine("Es tarifa B");
                Console.WriteLine("Cuota moderadora = el 46.1% de un salario mínimo diario legal vigente.");
            }

            if (salario >= 5)
            {
                Console.WriteLine("Es tarifa C");
                Console.WriteLine("Cuota moderadora = el 121.5% de un salario mínimo diario legal vigente.");
            }

            else if(salario < 0)
            {
                Console.WriteLine("Salario minimo no permitido");
            }

        }
    }
}
