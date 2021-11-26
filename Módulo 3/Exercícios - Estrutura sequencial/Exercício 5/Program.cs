/* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago. */

using System;


namespace Exercicio5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Código da peça1: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de peça1: ");
            int quantidade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor unitário da peça1: ");
            double preco1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Código da peça2: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de peça2: ");
            int quantidade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor unitário da peça2: ");
            double preco2 = double.Parse(Console.ReadLine());
            double total;

            total = preco1 * quantidade1 + preco2 * quantidade2;

            Console.WriteLine(total);
        }
    }
}