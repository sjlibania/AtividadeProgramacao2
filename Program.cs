using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA2EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int area;

            Console.Write("Digite o valor da base do retângulo:  ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura do retângulo:  ");
            h = int.Parse(Console.ReadLine());

            area = b * h;

            Console.Write("A area do retângulo é: ");
            Console.WriteLine(area);


            if (area > 100)
                Console.WriteLine("      Terreno Grande       ");





        }
    }
}
