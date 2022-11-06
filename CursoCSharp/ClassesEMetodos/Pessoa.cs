using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class Pessoa
    {
        // Convenção: usar letra maiúscula
        public string Nome; // Valor padrão: null
        public int Idade;   // Valor padrão: 0

        public string Apresentar()
        {
            return string.Format(
                $"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}

