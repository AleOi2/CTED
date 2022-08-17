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

	internal class Program
    {
		int a = 42;
        static void Main(string[] args)
        {
			//Program staticClass = new Program();
			//Console.WriteLine(staticClass.a);
			Pessoa p = new Pessoa("Wilian", 10);
            Console.WriteLine("Hello, World!");
        }
    }
}