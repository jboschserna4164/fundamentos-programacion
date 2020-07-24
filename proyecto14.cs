using System;

namespace Proyecto14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su salario mensual");
            double salariomensual = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su tipo de contrato: 1.Dependiente / 2.Independiente ");
            double tipocontrato = double.Parse(Console.ReadLine());

            double basecot = (salariomensual * 40) / 100;
            if (basecot < 877803)
            {
                basecot = 877803;
            }

            double bonificacion = salariomensual;

            int riesgo = 0;
            double salariorealmensual = 0, salarioanual = 0, deducciones = 0, pension = 0, eps = 0, arl = 0;



            switch (tipocontrato)
            {
                case 1:
                Console.WriteLine("Obtiene bonificacion");
                    arl = basecot * 0;
                    Console.WriteLine("ARL = " + arl);

                    eps = basecot * 0.04;
                    Console.WriteLine("EPS = " + eps);

                    pension = basecot * 0.04;
                    Console.WriteLine("PENSION = " + pension);

                    deducciones = arl + eps + pension;
                    Console.WriteLine("DEDUCCIONES = " + deducciones);

                    salariorealmensual = salariomensual - deducciones;
                    Console.WriteLine("SALARIO REAL MENSUAL = " + salariorealmensual);

                    salarioanual = ((salariorealmensual * 12) + bonificacion);
                    Console.WriteLine("SALARIO ANUAL = " + salarioanual);
                    break;

                case 2:
                    Console.WriteLine("Ingrese un numero de 1 al 5 equivalente al riesgo de su trabajo");
                    riesgo = int.Parse(Console.ReadLine());

                    switch (riesgo)
                    {
                        case 1:
                            arl = basecot * 0.00522;
                            Console.WriteLine("ARL = " + arl);

                            eps = basecot * 0.125;
                            Console.WriteLine("EPS = " + eps);

                            pension = basecot * 0.16;
                            Console.WriteLine("PENSION = " + pension);

                            deducciones = arl + eps + pension;
                            Console.WriteLine("DEDUCCIONES = " + deducciones);

                            salariorealmensual = salariomensual - deducciones;
                            Console.WriteLine("SALARIO REAL MENSUAL = " + salariorealmensual);

                            salarioanual = (salariorealmensual * 12);
                            Console.WriteLine("SALARIO ANUAL = " + salarioanual);
                            break;

                        case 2:
                            arl = basecot * 0.01044;
                            Console.WriteLine("ARL = " + arl);

                            eps = basecot * 0.125;
                            Console.WriteLine("EPS = " + eps);

                            pension = basecot * 0.16;
                            Console.WriteLine("PENSION = " + pension);

                            deducciones = arl + eps + pension;
                            Console.WriteLine("DEDUCCIONES = " + deducciones);

                            salariorealmensual = salariomensual - deducciones;
                            Console.WriteLine("SALARIO REAL MENSUAL = " + salariorealmensual);

                            salarioanual = (salariorealmensual * 12);
                            Console.WriteLine("SALARIO ANUAL = " + salarioanual);
                            break;

                        case 3:
                            arl = basecot * 0.02436;
                            Console.WriteLine("ARL = " + arl);

                            eps = basecot * 0.125;
                            Console.WriteLine("EPS = " + eps);

                            pension = basecot * 0.16;
                            Console.WriteLine("PENSION = " + pension);

                            deducciones = arl + eps + pension;
                            Console.WriteLine("DEDUCCIONES = " + deducciones);

                            salariorealmensual = salariomensual - deducciones;
                            Console.WriteLine("SALARIO REAL MENSUAL = " + salariorealmensual);

                            salarioanual = (salariorealmensual * 12);
                            Console.WriteLine("SALARIO ANUAL = " + salarioanual);
                            break;

                        case 4:
                            arl = basecot * 0.04350;
                            Console.WriteLine("ARL = " + arl);

                            eps = basecot * 0.125;
                            Console.WriteLine("EPS = " + eps);

                            pension = basecot * 0.16;
                            Console.WriteLine("PENSION = " + pension);

                            deducciones = arl + eps + pension;
                            Console.WriteLine("DEDUCCIONES = " + deducciones);

                            salariorealmensual = salariomensual - deducciones;
                            Console.WriteLine("SALARIO REAL MENSUAL = " + salariorealmensual);

                            salarioanual = (salariorealmensual * 12);
                            Console.WriteLine("SALARIO ANUAL = " + salarioanual);
                            break;

                        case 5:
                            arl = basecot * 0.06960;
                            Console.WriteLine("ARL = " + arl);

                            eps = basecot * 0.125;
                            Console.WriteLine("EPS = " + eps);

                            pension = basecot * 0.16;
                            Console.WriteLine("PENSION = " + pension);

                            deducciones = arl + eps + pension;
                            Console.WriteLine("DEDUCCIONES = " + deducciones);

                            salariorealmensual = salariomensual - deducciones;
                            Console.WriteLine("SALARIO REAL MENSUAL = " + salariorealmensual);

                            salarioanual = (salariorealmensual * 12);
                            Console.WriteLine("SALARIO ANUAL = " + salarioanual);
                            break;

                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

        }
    }
}
