using System;
namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            Console.Write("Digite a nota do aluno: ");
            Double.TryParse(Console.ReadLine(), out double nota);

            string entrada;
            Console.Write("Aluno possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;
            //bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}

