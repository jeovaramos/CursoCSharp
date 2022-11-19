using System;
namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada: Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }

        public void PrintCoordenada()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }
    public class Struct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 0;
            coordenadaInicial.Y = 0;

            coordenadaInicial.PrintCoordenada();
            for (int ii = 1; ii <= 10; ii++) {
                coordenadaInicial.MoverNaDiagonal(1);
                coordenadaInicial.PrintCoordenada();

            }

        }
    }
}

