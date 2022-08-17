using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amigo = new SubCelebridade();
        public void MeuAcesso()
        {
            Console.WriteLine("Amigo Proximo");
            Console.WriteLine(amigo.InfoPublica);
            // Console.WriteLine(amigo.CorDoOlho);
            Console.WriteLine(amigo.NumeroCelular);
            Console.WriteLine(amigo.JeitoDeFalar);
            //Console.WriteLine(amigo.SegredoFamilia);
            //Console.WriteLine(amigo.UsaMuitoPhotoshop);
        }


    }
}
