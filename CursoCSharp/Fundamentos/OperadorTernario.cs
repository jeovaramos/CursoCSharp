using System;
namespace CursoCSharp.Fundamentos
{
    public class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 7.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);

            bool bomComportamento = false;
            string resultado2 = nota >= 7.0 && bomComportamento
                ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado2);
        }
    }
}

