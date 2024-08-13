using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA2EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            
                Console.WriteLine("Digite a nota P1:");
                double P1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a nota P2:");
                double P2 = Convert.ToDouble(Console.ReadLine());

                double media = (P1 + 2 * P2) / 3;

                if (media >= 5)
                    Console.WriteLine("Aprovado");
                else
                    Console.WriteLine("Reprovado");

                Console.WriteLine("Média: " + media);
            
        }

    }
}

