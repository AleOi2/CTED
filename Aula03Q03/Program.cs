using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03Q03
{
    public class Carro
    {
        public int velocidadeAtual;
        protected readonly int velocidadeMaxima;
        public Carro(int velocidadeMaxima)
        {   
            this.velocidadeMaxima = velocidadeMaxima;
        }
        public int alterarVelocidade (int delta)
        {
            int novaVelocidade = velocidadeAtual + delta;
            if (novaVelocidade < 0)
            {
                velocidadeAtual = 0;
            } else if (novaVelocidade > velocidadeMaxima)
            {
                velocidadeAtual = velocidadeMaxima;
            } else
            {
                velocidadeAtual = novaVelocidade;
            }
            return velocidadeAtual;
        }

        public virtual int Acelerar()
        {
            Console.WriteLine("Acelerenando");
            return alterarVelocidade(5);
        }
        public int Frear()
        {
            return alterarVelocidade(-5);
        }
    };

    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }
        public override int Acelerar()
        {
            return alterarVelocidade(15);
        }
        public new int Frear()
        {
            return alterarVelocidade(-15);
        }
    }



    class Heranca
    {
        public static void Main()
        {
            Uno uno = new Uno();
            Console.WriteLine("Uno");
            Console.WriteLine(uno.Acelerar());
            Console.WriteLine(uno.velocidadeAtual);
            Console.WriteLine("Ferrari");
            Carro ferrari = new Ferrari();
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Frear());
            Console.WriteLine(ferrari.velocidadeAtual);
            Console.ReadLine();
            
        }
    }


}
