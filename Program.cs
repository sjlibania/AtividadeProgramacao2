using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA2EX6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P;
            double A;
            double R;

            Console.Write("Digite o valor do seu peso:  ");
            P = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da sua altura:  ");
            A = double.Parse(Console.ReadLine());

           R = P/ Math.Pow( A, 2);

            Console.WriteLine(" Relação: {0}", R);
            if (R < 20)
                Console.WriteLine("Abaixo do Peso");
            else
                if (R <= 25)
                Console.WriteLine("Peso ideal");
            else
                Console.WriteLine("Acima do Peso");









        }
    }
}
