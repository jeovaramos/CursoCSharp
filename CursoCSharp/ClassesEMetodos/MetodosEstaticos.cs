using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // Método de classe ou método estático
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // Método de instância
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }
    public class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine($"Resultado: {resultado}");

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));

            // Método de classe não é acessado
            // Console.WriteLine(calc.Multiplicar(2, 2));
        }
    }
}

