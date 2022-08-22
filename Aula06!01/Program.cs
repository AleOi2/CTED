using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_01
{
    public class NegativeException : Exception
    {
        public NegativeException() { }
        public NegativeException(string message) : base(message){ }
        public NegativeException(string message, Exception inner) : base(message, inner){ }
    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }

    class ExcecoesPersonailizadas
    {
        public static int PoisitivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);
            if (valor < 0)
            {
                throw new NegativeException("Númeor negativo...");
            }
            if (valor % 2 == 1)
            {
                throw new NegativeException("Valor Impar...");

            }
            return valor;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(PoisitivoPar());
            }
            catch (NegativeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImparException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

    }
}
