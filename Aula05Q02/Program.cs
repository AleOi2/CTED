using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Q02
{
    public abstract class Celular
    {
        public abstract string Assistente();
        public string Tocar() {
            return "trim trim trim";
        }
    }

    public class Sansung : Celular
    {
        public override string Assistente()
        {
            return "Ola meu nome e sansung";
        }
    }

    public class IPhone : Celular
    {
        public override string Assistente()
        {
            return "Ola meu nome é iphone";
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var celulares = new List<Celular> { new IPhone(), new Sansung() };
            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }

            Console.ReadLine();
        }
    }
}
