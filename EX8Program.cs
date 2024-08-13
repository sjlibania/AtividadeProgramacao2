using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;



                Console.WriteLine("Digite o valor de A:");
                A = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor de B:");
                B = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor de C:");
                C = Convert.ToDouble(Console.ReadLine());

                if ((A * A == B * B + C * C) ||
                    (B * B == A * A + C * C) ||
                    (C * C == A * A + B * B))
                {
                    Console.WriteLine("Os valores formam um triângulo retângulo.");
                }
                else
                {
                    Console.WriteLine("Os valores não formam um triângulo retângulo.");
                }
            }
        }



    


}
