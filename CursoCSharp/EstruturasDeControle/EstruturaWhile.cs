using System;
namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            Console.WriteLine("Tente adivinhar o número secreto de 1 a 15.");
            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira o seu palpite: ");
                int.TryParse(Console.ReadLine(), out palpite);
                tentativas++;
                tentativasRestantes--;

                if (palpite == numeroSecreto)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;

                    Console.WriteLine("Número encontrado em {0} tentativas",
                        tentativas);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Tente um número menor.");
                    Console.WriteLine("Tentativas restantes: {0}",
                        tentativasRestantes);
                } else
                {
                    Console.WriteLine("Tente um número maior.");
                    Console.WriteLine("Tentativas restantes: {0}",
                        tentativasRestantes);
                }

            }
            Console.WriteLine("Obrigado por jogar.");
        }
    }
}

