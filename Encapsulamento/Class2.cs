using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class FilhoReconhecido:SubCelebridade
    {
        public void MeuAcesso()
        {
            Console.WriteLine("Filho Reconhecido");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            // Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
