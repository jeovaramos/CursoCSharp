using System;
namespace CursoCSharp.Colecoes
{
    public class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[3];
            alunos[0] = "Bia";
            alunos[1] = "Carla";
            alunos[2] = "Lázaro";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            //double somatorio = 0;
            double[] notas = { 9.5, 7.2, 8.4, 9.6, 6.1 };
            //foreach (var nota in notas)
            //{
            //    somatorio += nota;
            //}

            //double media = somatorio / notas.Length;

            // Outra maneira
            //double media = notas.Sum() / notas.Length;
            //Console.WriteLine(media);

            // Outra maneira
            Console.WriteLine(notas.Average());

            char[] letras = { 'A', 'r', 'a', 'a', 'y' };
            Console.WriteLine(letras);

            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}

