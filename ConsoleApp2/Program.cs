namespace ConsoleApp1
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        public string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set { Nome = value; }
        }
        public double Preco { get; set; }

        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco);
        }
        public CarroOpcional() { }
        public CarroOpcional(string name, double preco)
        {
            Nome = name;
            Preco = preco;
        }
    }
    internal class Program
    {
        int valor = 30;
        static void multipleArgs(params string[] conjunto)
        {
            foreach (var valor in conjunto)
            {
                Console.WriteLine(valor);
            }

        }


        static void Main(string[] args)
        {
            //Program program = new Program();
            //Console.WriteLine(program.valor);
            //multipleArgs("A1", "A3", "A4");
            //Console.WriteLine("Verficando teste");
            //Console.ReadLine();
        }
    }
}
