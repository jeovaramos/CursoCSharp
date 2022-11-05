using System;
namespace CursoCSharp.Fundamentos
{
    public class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a TV de 50''? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o Sorvete? {0}", comprouSorvete);

            bool comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a TV de 32''? {0}", comprouTv32);

            Console.WriteLine("Ficou na dieta? {0}", !comprouSorvete);

        }
    }
}

