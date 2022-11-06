using System;
namespace CursoCSharp.EstruturasDeControle
{
    public class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine($"Números pares entre 1 e {intervalo}:");

            for (int ii = 1; ii <= intervalo; ii++)
            {
                if (ii % 2 == 1) continue;
                Console.Write($"{ii} ");
            }
        }
    }
}

