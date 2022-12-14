using System;
namespace CursoCSharp.Fundamentos
{
    public class OperadoresAtribuicao
    {
        public static void Executar()
        {
            int num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = num1 + 10;
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1
            b--; // b = b - 1

            Console.WriteLine($"a = {a}, b = {b}");

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine($"c = {c.nome}, d = {d.nome}");

        }
    }
}

