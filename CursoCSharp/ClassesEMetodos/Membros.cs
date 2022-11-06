﻿using System;
namespace CursoCSharp.ClassesEMetodos // Não precisa importar dentro do mesmo namespace
{
    public class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}

