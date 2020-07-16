using System;

namespace proyecto9
{
    class Program
    {
        static void Main(string[] args)
        {
            //desafio 01 : calculo de tarifa
            Console.WriteLine("Ingrese la cantidad de salarios minimos que gana");            
            int salario = int.Parse(Console.ReadLine());

            if(salario >= 0 &&  salario < 2)
            {
                Console.WriteLine("Es tarifa A");
            }

            if (salario >= 2 && salario < 4)
            {
                Console.WriteLine("Es tarifa B");
            }


            if (salario >= 4){
                Console.WriteLine("Es tarifa C");
            }

            else if (salario < 0)
            {
                Console.WriteLine("salario minimo no permitido");
            }
                           
        }
    }
}
