using System;
namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento com uma nota de 0 a 5:");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0: // Cuidado, também entra no caso de valor não numérico.
                    Console.WriteLine("Péssimo");
                    break;
                case 1: // Caso a nota seja 1 ou 2
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    {
                        Console.WriteLine("Regular");
                        break;
                    }
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    break;
                default:
                    Console.WriteLine("Nota inválida.");
                    break;


            }
            Console.WriteLine("Fim.");
        }
    }
}

