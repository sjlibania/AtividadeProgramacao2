using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA2EX11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Digite a nota P1:");
                double P1 = Convert.ToDouble(Console.ReadLine());

                // Calcula a nota necessária em P2 para que a média seja 5
                double P2_necessaria = (15 - P1) / 2;

                Console.WriteLine("Para ser aprovado, você precisa tirar " + P2_necessaria + " na P2.");
    
            }
        }


    }

