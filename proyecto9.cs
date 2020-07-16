using System;

namespace proyecto9
{
    class Program
    {
        static void Main(string[] args)
        {
            //desafio 01 : calculo de tarifa
            Console.WriteLine("Ingrese su salario");            
            double salario = double.Parse(Console.ReadLine());

            double salariomin = salario / 877803;
            Console.WriteLine(salariomin + " SMMLV");

            if(salariomin >= 0 &&  salariomin < 2)
            {
                Console.WriteLine("Es tarifa A");
            }

            if (salariomin >= 2 && salariomin < 4)
            {
                Console.WriteLine("Es tarifa B");
            }


            if (salariomin >= 4){
                Console.WriteLine("Es tarifa C");
            }

            else if (salariomin < 0)
            {
                Console.WriteLine("salario minimo no permitido");
            }
                           
        }
    }
}
