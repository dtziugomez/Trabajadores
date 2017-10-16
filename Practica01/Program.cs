using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, nc;
            double CV, TA, DI, CCV = 0, CTA = 0, DC, CDC = 0, CDI = 0;
            Console.WriteLine("¿Dime cuantos empleados tiene la empresa?");
            nc = Int32.Parse(Console.ReadLine());
            string[] nom = new string[nc];
            string[] ced = new string[nc];
            double[] sb = new double[nc];
            double[] vr = new double[nc];
            string[] ec = new string[nc];
            double[] nh = new double[nc];
            double[] sn = new double[nc];
            for (i = 0; i < nc; i++)
            {
                Console.WriteLine("Escribe el nombre del empleado: ");
                nom[i] = Console.ReadLine();
                Console.WriteLine("Escribe la cèdula del empleado: ");
                ced[i] = Console.ReadLine();
                Console.WriteLine("Sueldo base: ");
                sb[i] = Double.Parse(Console.ReadLine());
                Console.WriteLine("Ventas realizadas: ");
                vr[i] = Double.Parse(Console.ReadLine());
                Console.WriteLine("Estado civil: ");
                ec[i] = Console.ReadLine();
                if (ec[i] == "C" || ec[i] == "c")
                {
                    Console.WriteLine("Numero de hijos: ");
                    nh[i] = Double.Parse(Console.ReadLine());
                }
                CV = vr[i] * .05;
                TA = sb[i] + CV;
                if (TA <= 400)
                {
                    DI = 0;
                }
                else
                {
                    if (TA > 400 || TA <= 800)
                    {
                        DI = TA * .03;
                    }
                    else
                    {
                        if (TA > 800 || TA <= 100)
                        {
                            DI = TA * .04;
                        }
                        else
                        {
                            DI = TA * .06;
                        }
                    }
                }
                if (ec[i] == "S" || ec[i] == "s")
                {
                    DC = 100;
                }
                else
                {
                    if (nh[i] == 0)
                    {
                        DC = 150;
                    }
                    else
                    {
                        DC = 150 + (80 * nh[i]);
                    }
                }
                sn[i] = sb[i] + CV - DI - DC;
                CCV = CCV + CV;
                CDI = CDI + DI;
                CDC = CDC + DC;
                CTA = CTA + sn[i];
            }
            for (i = 0; i < nc; i++)
            {
                Console.WriteLine("El empleado llamado: {0}", nom[i]);
                Console.WriteLine("");
                Console.WriteLine("Con la cèdula: {0}", ced[i]);
                Console.WriteLine("");
                Console.WriteLine("Tiene un sueldo neto de: {0}", sn[i]);
                Console.WriteLine("");
                Console.WriteLine("La empresa tiene un monto total a pagar por concento de sueldos de: {0}", CTA);
                Console.WriteLine("");
                Console.WriteLine("El monto total por comisiones de ventas es de: {0}", CCV);
                Console.WriteLine("");
                Console.WriteLine("El monto total de los descuentos por impuestos es de: {0}", CDI);
                Console.WriteLine("");
                Console.WriteLine("El monto total de seguros es de: {0}", CDC);
            }
            Console.ReadLine();

        }
    }
}

