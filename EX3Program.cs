using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA2EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("Digite o primeiro valor:  ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor:  ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor:  ");
            c = int.Parse(Console.ReadLine());

            if (a == b)
                if (a == c)
                    Console.WriteLine("Iguais");
                else
                    if (a > c)
                    Console.WriteLine("1°/2°");
                else
                    Console.WriteLine("3°");
            else
                if (a == c)
                    if (a > b)
                       Console.WriteLine("1°/3°");
                    else
                    Console.WriteLine("2°");
           else         
                if (b == c)
                    if ( b > a)
                        Console.WriteLine("2°/3°");
                     else
                       Console.WriteLine("1°");
                else
                      if (a > b)
                          if (a > c)
                             Console.WriteLine("1°");
                           else
                             Console.WriteLine("3°");
                      else
                          if (b > c)
                               Console.WriteLine("2°");
                          else
                               Console.WriteLine("3°");



        }  
    }
}
