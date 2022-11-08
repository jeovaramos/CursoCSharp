using System;
namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
    }

    public class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComun = new CalculadoraComum();
            int resultado = calculadoraComun.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComun.Subtrair(2, 7));
            Console.WriteLine(calculadoraComun.Multiplicar(7, 8));

            var calculadoraCadeia = new CalculadoraCadeia();
            Console.WriteLine("Testando CalculadoraCadeia.");
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir()
                .Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(3).Multiplicar(3).Resultado();
            Console.WriteLine(resultado);
        }
    }
}

