/* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 19,63 */

using System;
using System.Globalization;

namespace Course
{ 
    class program
    {
        static void Main(string[] args)
        {
            double raio = 2.5;
            double area = Math.PI * (raio * raio);

            Console.WriteLine(area.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
