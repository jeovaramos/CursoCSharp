using System;
namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do
            {
                Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}", entrada);
                Console.WriteLine("Deseja continuar? (s/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
            Console.WriteLine("Fim do programa.");
        }
    }
}

