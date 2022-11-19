using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;

        // valor imutável de somente leitura definido no construtor
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}",
                Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }

    }
    public class ReadOnly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Maria", new DateTime(1964, 6, 21));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}

