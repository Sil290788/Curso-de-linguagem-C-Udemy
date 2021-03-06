// Em um novo programa, inicia as seguintes variaveis:

using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"{produto1} cujo o preço é {preco1:F2} reais");
            Console.WriteLine($"{produto2} cujo o preço é {preco2:F2} reais");

            Console.WriteLine($"O cliente tem {idade} anos, código do produto {codigo} e sexo {genero}", idade, codigo, genero);

            Console.WriteLine(medida.ToString("F3"));
            Console.WriteLine(medida.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}