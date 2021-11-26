// Faça um programa que mostre a hora atual

using System;

namespace estruturaCondicional
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a hora: ");

            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }
        }
    }
}
