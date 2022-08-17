using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Q05
{
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1500000;
        }
    }

    //class SouFilho : SemFilho {
    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class Pai : Avo
    {
        public override sealed bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SemFilho semfilho = new SemFilho();
            Console.WriteLine(semfilho.ValorDaFortuna());
            FilhoRebelde filhoRebelde = new FilhoRebelde();
            Console.WriteLine(filhoRebelde.HonrarNomeFamilia());
        }
    }
}
