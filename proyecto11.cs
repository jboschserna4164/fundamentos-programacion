using System;
using System.Runtime.InteropServices;

namespace proyecto11
{
    class Program
    {
        static void Main(string[] args)
        {
            //evaluacion de practica. tema tipos de contrato
            Console.WriteLine("Ingrese su salario mensual");
            double salario_mensual = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de contrato: 1.Dependiente o 2.Independiente ");
            int tipo_contrato = int.Parse(Console.ReadLine());
            
            //calcular la base de cotizacion 
            double basecot = (salario_mensual * 40) / 100;
            if (basecot < 877803)
            {
                basecot = 877803;
            }


            //tipo contrato si es independiente
            if (tipo_contrato == 2)
            {
                //tabla de riesgo y de deducciones
                Console.WriteLine("Ingrese un numero del 1 al 5 de acuerdo a lo riesgoso que es su trabajo");
                int riesgo = int.Parse(Console.ReadLine());

                if (riesgo == 1)
                {
                    Console.WriteLine("Base de cotizacion = " + basecot);
                    //calcular las deducciones
                    double deduccion_Pension = basecot * 0.16;
                    double deduccion_EPS = basecot * 0.125;
                    double deduccion_Arl = basecot * 0.00522;
                    Console.WriteLine("Pension = " + deduccion_Pension);
                    Console.WriteLine("Eps = " + deduccion_EPS);
                    Console.WriteLine("Arl = " + deduccion_Arl);
                    double deducciones = deduccion_Pension + deduccion_EPS + deduccion_Arl;
                    Console.WriteLine("Deducciones = " + deducciones);
                    //calcular salario real mensual
                    double salarioreal_mensual = salario_mensual - deducciones;
                    Console.WriteLine("Salario real mensual = " + salarioreal_mensual);
                    //calcular salario anual
                    double salario_anual = (salarioreal_mensual * 12);
                    Console.WriteLine("Salario anual = " + salario_anual);
                }

                if(riesgo == 2)
                {
                    //calcular las deducciones
                    double deduccion_Pension = basecot * 0.16;
                    double deduccion_EPS = basecot * 0.125;
                    double deduccion_Arl = basecot * 0.01044;
                    Console.WriteLine("Pension = " + deduccion_Pension);
                    Console.WriteLine("Eps = " + deduccion_EPS);
                    Console.WriteLine("Arl = " + deduccion_Arl);
                    double deducciones = deduccion_Pension + deduccion_EPS + deduccion_Arl;
                    Console.WriteLine("Deducciones = " + deducciones);
                    //calcular salario real mensual
                    double salarioreal_mensual = salario_mensual - deducciones;
                    Console.WriteLine("Salario real mensual = " + salarioreal_mensual);
                    //calcular salario anual
                    double salario_anual = (salarioreal_mensual * 12);
                    Console.WriteLine("Salario anual = " + salario_anual);
                }

                if(riesgo == 3)
                {
                    //calcular las deducciones
                    double deduccion_Pension = basecot * 0.16;
                    double deduccion_EPS = basecot * 0.125;
                    double deduccion_Arl = basecot * 0.02436;
                    Console.WriteLine("Pension = " + deduccion_Pension);
                    Console.WriteLine("Eps = " + deduccion_EPS);
                    Console.WriteLine("Arl = " + deduccion_Arl);
                    double deducciones = deduccion_Pension + deduccion_EPS + deduccion_Arl;
                    Console.WriteLine("Deducciones = " + deducciones);
                    //calcular salario real mensual
                    double salarioreal_mensual = salario_mensual - deducciones;
                    Console.WriteLine("Salario real mensual = " + salarioreal_mensual);
                    //calcular salario anual
                    double salario_anual = (salarioreal_mensual * 12);
                    Console.WriteLine("Salario anual = " + salario_anual);
                }

                if(riesgo == 4)
                {

                    //calcular las deducciones
                    double deduccion_Pension = basecot * 0.16;
                    double deduccion_EPS = basecot * 0.125;
                    double deduccion_Arl = basecot * 0.04350;
                    Console.WriteLine("Pension = " + deduccion_Pension);
                    Console.WriteLine("Eps = " + deduccion_EPS);
                    Console.WriteLine("Arl = " + deduccion_Arl);
                    double deducciones = deduccion_Pension + deduccion_EPS + deduccion_Arl;
                    Console.WriteLine("Deducciones = " + deducciones);
                    //calcular salario real mensual
                    double salarioreal_mensual = salario_mensual - deducciones;
                    Console.WriteLine("Salario real mensual = " + salarioreal_mensual);
                    //calcular salario anual
                    double salario_anual = (salarioreal_mensual * 12);
                    Console.WriteLine("Salario anual = " + salario_anual);
                }

                if(riesgo == 5)
                {
                    //calcular las deducciones
                    double deduccion_Pension = basecot * 0.16;
                    double deduccion_EPS = basecot * 0.125;
                    double deduccion_Arl = basecot * 0.06960;
                    Console.WriteLine("Pension = " + deduccion_Pension);
                    Console.WriteLine("Eps = " + deduccion_EPS);
                    Console.WriteLine("Arl = " + deduccion_Arl);
                    double deducciones = deduccion_Pension + deduccion_EPS + deduccion_Arl;
                    Console.WriteLine("Deducciones = " + deducciones);
                    //calcular salario real mensual
                    double salarioreal_mensual = salario_mensual - deducciones;
                    Console.WriteLine("Salario real mensual = " + salarioreal_mensual);
                    //calcular salario anual
                    double salario_anual = (salarioreal_mensual * 12);
                    Console.WriteLine("Salario anual = " + salario_anual);
                }

            }

            else if(tipo_contrato == 2)
            {
                Console.WriteLine("Es dependiente");
            }

            //tipo contrato si es dependiente
            if (tipo_contrato == 1)
            {
                Console.WriteLine("Incluye una bonificacion (prima) ");
                double prima = 1 * salario_mensual;
                Console.WriteLine("La prima es = " + prima);                
                Console.WriteLine("Base de cotizacion = " + basecot);
                //calcular las deducciones
                double deduccion_EPS = basecot * 0.04;
                double deduccion_Pension = basecot * 0.04;
                double deduccion_Arl = basecot * 0;
                Console.WriteLine("Pension = " + deduccion_Pension);
                Console.WriteLine("Eps = " + deduccion_EPS);
                Console.WriteLine("Arl = " + deduccion_Arl);
                double deducciones = deduccion_Pension + deduccion_EPS + deduccion_Arl;
                Console.WriteLine("Deducciones = " + deducciones);
                //calcular salario real mensual
                double salarioreal_mensual = salario_mensual - deducciones;
                Console.WriteLine("Salario real mensual = " + salarioreal_mensual);
                //calcular salario anual
                double salario_anual = ((salarioreal_mensual * 12) + prima);
                Console.WriteLine("Salario anual = " + salario_anual);
            }

            else if(tipo_contrato == 2)
            {
                Console.WriteLine("No incluye prima ");
            }
;
        
        }
    }
}
