using System;
namespace CursoCSharp.EstruturasDeControle
{
    public class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}", numero);
            for (int ii = 1; ii <= 50; ii++)
            {
                Console.WriteLine($"{ii} é o número que queremos?");
                if (ii == numero)
                {
                    Console.WriteLine("Sim.");
                    break;
                }
                else Console.WriteLine("Não.");
            }
            Console.WriteLine("Fim.");
        }
    }
}

