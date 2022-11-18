using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        // Sem descrição de public, implicitamente declara private
        double desconto = 0.1;
        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        // Propriedade nativa autoimplementada
        public double Preco { get; set; }

        // Somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco);  // Lambda
            //get
            //{
            //    return PrecoComDesconto - (desconto * Preco);
            //}
        }

        public CarroOpcional() { }

        public CarroOpcional(string nome, double preco)
        {
            //this.nome = nome
            // Automaticamente chama o set da propriedade
            Nome = nome;
            Preco = preco;
        }
    }
    public class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3499.9);
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            Console.WriteLine(op1.PrecoComDesconto);

            // Erro, propriedade de somente leitura.
            //op1.PrecoComDesconto = 2000;

            var op2 = new CarroOpcional();
            op2.Nome = "Direção elétrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);

        }
    }
}

