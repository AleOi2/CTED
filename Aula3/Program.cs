
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Program
    {
        interface Ponto
        {
            void MoverNaDiagonal(int diagonal);
        }

        struct Coordenada: Ponto
        {
            public int X;
            public int Y;
            public Coordenada(int x, int y) {
                X = x;
                Y = y;
            }
            public void MoverNaDiagonal(int delta)
            {
                X += delta;
                Y += delta;
            }
        }

        class CoordenadaByRef : Ponto
        {
            public int X;
            public int Y;
            public CoordenadaByRef(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void MoverNaDiagonal(int delta)
            {
                X += delta;
                Y += delta;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Aula 3");
            Coordenada coordenada = new Coordenada(10, 20);
            coordenada.MoverNaDiagonal(20);
            Console.WriteLine(coordenada.X);
            Coordenada coordenadaV2 = coordenada;
            Console.WriteLine(coordenadaV2.X);
            coordenadaV2.MoverNaDiagonal(20);
            Console.WriteLine(coordenada.X);
            Console.WriteLine(coordenadaV2.X);
            Console.WriteLine("Fim");

            CoordenadaByRef coordenadaByRef = new CoordenadaByRef(10, 20);
            coordenadaByRef.MoverNaDiagonal(20);
            Console.WriteLine(coordenadaByRef.X);
            CoordenadaByRef coordenadaV2ByRef = coordenadaByRef;
            Console.WriteLine(coordenadaV2ByRef.X);
            coordenadaV2ByRef.MoverNaDiagonal(20);
            Console.WriteLine(coordenadaByRef.X);
            Console.WriteLine(coordenadaV2ByRef.X);


            Console.ReadLine();
        }
    }
}
