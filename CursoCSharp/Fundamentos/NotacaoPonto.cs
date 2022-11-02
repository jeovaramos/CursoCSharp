using System;
namespace CursoCSharp.Fundamentos
{
	public class NotacaoPonto
	{
		public static void Executar()
		{
			var saudacao = "Olá".ToUpper().Insert(3, " World!")
				.Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);
			Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); // ? = Se não for nulo

            string stringVazia = string.Empty;
            Console.WriteLine(stringVazia?.Length); // ? = Se não for nulo

        }
    }
}

