using System;
namespace CursoCSharp.Fundamentos
{
    public class Inferencia
    {
        public static void Executar()
        {
            //Variáveis implícitas devem ser inicializadas
            var nome = "Jeová";
            nome = "J";
            //nome = 1;
            Console.WriteLine(nome);

            int idade;
            idade = 25;
            Console.WriteLine(idade);

        }
    }
}

