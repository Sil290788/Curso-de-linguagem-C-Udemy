// Aprendendo a diferença entre Console.WriteLine e Console.Write

using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35789;
            string nome = "Maria";

            // 2° EXEMPLO DA AULA - IMPRESSÃO PLACEHOLDERS
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);

            // 3° EXEMPLO DA AULA - IMPRESSÃO INTERPOLAÇÃO
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            
            // 4º EXEMPLO DA AULA - CONCATENAÇÃO
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + "reais");
            
            /* 1° EXEMPLO DA AULA
             char genero = 'F';
             int idade = 32;
             double saldo = 10.357685;
             string nome = "Maria";

              Console.WriteLine(genero);
              Console.WriteLine(idade);
              Console.WriteLine(saldo.ToString("F2")); //ToString("F") serve para delimitar a quantidade de casas decimais após a vírgula. O dois significa 2 casas!
              Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); 
              Console.WriteLine(nome);
              Console.Write("Bom dia!");
              Console.Write("Boa tarde!"); */
            
        }
    }
}

/*A diferença do Console.WriteLine é que ele coloca uma quebra de linha na frente do que for imprimir.
 O Console.Write não coloca.

 Se for necessário imprimir o número com "." ao ínves de "," é importante acrescentar "using System.Globalization e o no console acrescentar: 
 Console.WriteLine(saldo.ToString("F2", culture.Info.InvariantCulture)) */
