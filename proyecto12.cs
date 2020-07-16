using System;

namespace proyecto12
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedimos el peso y la altura al usuario
            Console.WriteLine("Ingrese su peso en kg");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su altura en m");
            double altura = double.Parse(Console.ReadLine());

            //convertimos la altura en m cuadrados
            double altura1 = altura * altura;

            //hallamos el IMC
            double imc = peso / altura1;
            Console.WriteLine("Su indice de masa corporal es " + imc);

            if(imc < 18.5)
            {
                Console.WriteLine("Esta bajo de peso");
            }

            if(imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Esta normal de peso");
            }

            if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Esta en sobrepeso");
            }

            if(imc >= 30)
            {
                Console.WriteLine("Esta en obesidad");
            }

        }
    }
}
