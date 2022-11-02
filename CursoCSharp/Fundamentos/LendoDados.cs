using System;
using System.Globalization;
namespace CursoCSharp.Fundamentos
{
    public class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string? nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int? idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o seu Salário? ");
            double? salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} tem {idade} anos e ganha R${salario}.");

        }
    }
}

