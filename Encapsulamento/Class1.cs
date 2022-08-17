namespace Encapsulamento{
    public class SubCelebridade
    {
        public string InfoPublica = "Tenho um instagram";
        protected string CorDoOlho = "Verde";

        //mesmo projeto assembly
        internal ulong NumeroCelular = 932328398429;
        protected internal string JeitoDeFalar = "Uso muitas gírias";
        private protected string SegredoFamilia = "Bla bla";
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);


        }

    }
}