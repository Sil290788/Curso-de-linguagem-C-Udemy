//Fazer um programa para ler um número inteiro, e dizer se ele é par ou ímpar.

using System;

namespace estruturaCondicional
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("O número é PAR! ");
            }                                               //ESTRUTUTA COMPOSTA
            else
            {
                Console.WriteLine("O número é ÍMPAR!");
            }
        }
    }
}
