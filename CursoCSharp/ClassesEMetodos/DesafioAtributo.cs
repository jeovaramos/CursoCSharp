using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            // Desafio: Acessar variável "a" dentro do método Executar.

            // Criar uma instância para acessar atributo da instância.
            var desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}

