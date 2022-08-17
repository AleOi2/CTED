using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public  class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho nao reconhecido");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(JeitoDeFalar);

        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amigo = new SubCelebridade();
    }
}
