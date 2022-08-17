using System;
namespace ConsoleApp1
{
	public class Pessoa
	{
		public string Nome;
		public int Idade;

		public string Apresentar()
		{
			return string.Format($"Ola. Me chamo {Nome} e tenho {Idade} anos");

		}

		public void ApresentarNoConsole()
		{
			Console.WriteLine(Apresentar());
		}

		public void Zerar()
		{
			Nome = "";
			Idade = 0;
		}

		public Pessoa(string Nome, int Idade)
		{
			this.Nome = Nome;
			this.Idade = Idade;

		}
	}
}