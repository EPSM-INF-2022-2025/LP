using System;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declarar variaveis
            int num1, num2;

            Console.WriteLine("Qual o número 1?");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o número 2?");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 % num2 == 0)
                {
                    Console.WriteLine(num1 + " é múltiplo de " + num2);
                }
                else
                {
                    Console.WriteLine(num1 + " NÃO é múltiplo de " + num2);
                }
            } else if (num2 > num1)
            {
                if (num2 % num1 == 0)
                {
                    Console.WriteLine(num2 + " é múltiplo de " + num1);
                }
                else
                {
                    Console.WriteLine(num2 + " NÃO é múltiplo de " + num1);
                }
            } else
            {
                Console.WriteLine("Números são IGUAIS");
            }
            


        }
    }
}
