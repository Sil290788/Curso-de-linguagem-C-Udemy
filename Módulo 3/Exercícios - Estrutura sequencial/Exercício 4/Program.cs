/* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
decimais. */

using System;
using System.Globalization;

namespace Exercicio4
{
    class program
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Número do funcionário: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de horas trabalhadas: ");
            double horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor do sálario: ");
            double valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            valorHora = valorHora * horas;

            Console.WriteLine(horas);
            Console.WriteLine(valorHora);
                
        }
    }
}