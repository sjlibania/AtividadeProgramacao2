using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA2EX9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            



                Console.WriteLine("Digite o peso (kg):");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a altura (m):");
                double altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o sexo (M para masculino, F para feminino):");
                char sexo = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

                double R = peso / (altura * altura);

                if (sexo == 'F')
                {
                    if (R < 19)
                        Console.WriteLine("Abaixo do peso");
                    else if (R < 24)
                        Console.WriteLine("Peso ideal");
                    else
                        Console.WriteLine("Acima do peso");
                }
                else if (sexo == 'M')
                {
                    if (R < 20)
                        Console.WriteLine("Abaixo do peso");
                    else if (R < 25)
                        Console.WriteLine("Peso ideal");
                    else
                        Console.WriteLine("Acima do peso");
                }
                else
                {
                    Console.WriteLine("Sexo inválido.");
                }
            }
        }



    }


