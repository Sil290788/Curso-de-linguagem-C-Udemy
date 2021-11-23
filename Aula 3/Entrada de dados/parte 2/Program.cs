using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(altura.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(idade);

            /* int n1 = int.Parse(Console.ReadLine());         **Converter STRING para INT "int.Parse"
            char ch = char.Parse(Console.ReadLine());          **Converter STRING para CHAR "char.Parse"
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);         **Converter STRING para DOUBLE "double.Parse"

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F1", CultureInfo.InvariantCulture)); */
           
        }
    }
}