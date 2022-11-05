using System;
namespace CursoCSharp.Fundamentos
{
    public class OperadoresRelacionais
    {
        public static void Executar()
        {
            double nota = 6.0;
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota inválida? {0}", nota > 0.0);
            Console.WriteLine("Nota máxima? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);

        }
    }
}

