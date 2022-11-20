using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }

    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;  // int é uma struct
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Roberto",
                Idade = 33
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 35;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }
}
