/* Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho, e depois mostrar os dados na tela: */

using System;
using System.Globalization;

namespace Course
{
    class program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int idade = int.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quantidade);
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}