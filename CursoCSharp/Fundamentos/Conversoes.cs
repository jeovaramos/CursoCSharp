using System;
namespace CursoCSharp.Fundamentos
{
    public class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;

            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota; // Conversão com perda de informação
            Console.WriteLine($"Nota truncada: {nota}");

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();

            // Duas formas de converter para inteiro
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numeroConvertido1;
            int.TryParse(palavra, out numeroConvertido1);
            Console.WriteLine("Numero convertido 1: {0}", numeroConvertido1);

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numeroConvertido2);
            Console.WriteLine("Numero convertido 2: {0}", numeroConvertido2);
        }
    }
}

