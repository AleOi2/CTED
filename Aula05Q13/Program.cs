using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Q13
{
    public class Conta
    {
        double Saldo;
        public Conta(double saldo)
        {
            Saldo += saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo Insuficiente");
            }
            Saldo -= valor;
        }
        static void Main(string[] args)
        {
            var conta = new Conta(1223.45);
            try
            {
                //int.Parse("abc");
                int number;
                bool result = int.TryParse("ab", out number);
                if (!result)
                {
                    throw new ArgumentException("Erro de excessao");
                }
                Console.WriteLine(number);

                conta.Sacar(100);
                Console.WriteLine("Retiada com sucesso");
            }
            catch (Exception err)
            {
                Console.WriteLine(err.GetType().Name);
                Console.WriteLine(err.Message);
                Console.WriteLine(err.StackTrace);
            }
            finally
            {
                Console.WriteLine("Obrigado");
            }
        }
    }
}
