using System;
namespace CursoCSharp.Fundamentos
{
    public class Interpolacao
    {
        public static void Executar()
        {
            string produto = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + produto + " da marca "
                + marca + " custa " + preco + ".");

            Console.WriteLine("O {0} da marca {1} custa {2}.",
                produto, marca, preco);

            Console.WriteLine($"O {produto} da marca {marca} custa {preco}.");

        }
    }
}

