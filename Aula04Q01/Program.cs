using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Aula04Q01
{
    public class Comida
    {
        public double peso;
        public Comida(double peso)
        {
            this.peso = peso;
        }
    }
    public class Feijao : Comida
    {
        public Feijao(double peso) : base(peso)
        {

        }
    }

    public class Arroz : Comida
    {
        public Arroz(double peso) : base(peso)
        {

        }

    }

    public class Carne : Comida
    {
        public Carne(double peso) : base(peso)
        {

        }

    }

    public class Pessoa
    {
        public double Peso;

        public void Comer(Comida comida)
        {
            Peso += comida.peso;
        }

    }
    class Program
    {
        public static void Main()
        {
            Pessoa joao = new Pessoa();
            Carne carne = new Carne(10);
            Feijao feijao = new Feijao(20);
            Arroz arroz = new Arroz(30);
            joao.Comer(carne);
            joao.Comer(arroz);
            joao.Comer(feijao);
            Console.WriteLine("O peso da pessoa vale:");
            Console.WriteLine(joao.Peso);
            //Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b",
            //          RegexOptions.Compiled | RegexOptions.IgnoreCase);

            //Regex rx = new Regex("The",
            //          RegexOptions.Compiled | RegexOptions.IgnoreCase);
            //string text = "The the quick brown fox  fox jumps over the lazy dog dog.";
            //MatchCollection matches = rx.Matches(text);
            //foreach (Match match in matches)
            //{
            //    GroupCollection groups = match.Groups;
            //    Console.WriteLine("'{0}' repeated at positions {1} and {2}",
            //                      groups["word"].Value,
            //                      groups[0].Index,
            //                      groups[1].Index);
            //}
            Console.ReadLine();
        }

    }

}
