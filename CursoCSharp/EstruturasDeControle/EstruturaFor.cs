using System;
namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaFor
    {
        public static void Executar()
        {
            int ii = 1;

            Console.WriteLine("Usando o while.");
            while (ii <= 10)
            {
                Console.WriteLine("O valor de ii é = {0}", ii);
                ii++;
            }
            Console.WriteLine("Usando o for.");
            for (int jj = 1; jj <= 10; jj++)
            {
                Console.WriteLine("O valor de jj é = {0}", ii);
            }

            double somatorio = 0;
            string entrada;

            Console.Write("Insira o tamanho da turma: ");
            int.TryParse(Console.ReadLine(), out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                somatorio += notaAtual;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine($"Média da turma: {media}.");
        }
    }
}

