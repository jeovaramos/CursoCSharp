using System;
namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;
            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
            } else
            { // Para uma única sentença também pode-se usar sem o bloco {}
                Console.WriteLine("Recuperação");
            }

        }
    }
}

