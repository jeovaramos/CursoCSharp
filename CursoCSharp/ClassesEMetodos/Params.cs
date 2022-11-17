using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class Params
    {
        // Use para passar n parâmetros.
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Executar()
        {
            Recepcionar("Pedro", "Manu", "Roger");

        }
    }
}

