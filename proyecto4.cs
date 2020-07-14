using System;

namespace proyecto4
{
    class Program
    {
        static void Main(string[] args)
        {   
            //desafio 01: conversion bin2dec

            //pedir los 5 datos numericos binarios  
            Console.WriteLine("ingrese el primer dato numerico binario(0 o 1)");
            int b4 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo dato numerico binario(0 o 1)");
            int b3 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tercer dato numerico binario(0 o 1)");
            int b2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el cuarto dato numerico binario(0 o 1)");
            int b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el quinto dato numerico binario(0 o 1)");
            int b0 = int.Parse(Console.ReadLine());

            //convertimos de binario a decimal
            int b = (b4 * 2 * 2 * 2 * 2 ) + (b3 * 2 * 2 * 2 ) + (b2 * 2 * 2 ) + (b1 * 2 ) + (b0 * 1);
            Console.WriteLine("De binario a decimal = " + b);
        }
    }
}
