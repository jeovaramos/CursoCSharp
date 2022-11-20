using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;

            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }
        public static void Executar()
        {
            int numeroRef = 3;
            AlterarRef(ref numeroRef);
            Console.WriteLine(numeroRef);

            int outA;
            AlterarOut(out outA, out int outB);
            Console.WriteLine($"{outA}, {outB}");

        }
    }
}

