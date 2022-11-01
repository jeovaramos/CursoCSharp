using System;
namespace CursoCSharp.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar()
        {
            // área da circunferência
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;

            Console.WriteLine("A área é " + area);

            // Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols: " + saldoDeGols);

            sbyte salario = sbyte.MaxValue;
            Console.WriteLine("Salário de: R$" + salario);

            int menorValorInt = int.MinValue;
            int maiorValorInt = int.MaxValue;
            Console.Write("Menor e maior valor do tipo int: ");
            Console.WriteLine(menorValorInt + " <--> " + maiorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial: " + populacaoMundial);

            float precoComputador = 1299.99f; //Pode ser F maiúsculo
            Console.WriteLine("Preço do computador: " + precoComputador);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas: " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra"+ letra);

            string texto = "Bem vindo ao curso de C#!";
            Console.WriteLine(texto);

        }
    }
}

