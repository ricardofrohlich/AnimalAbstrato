namespace AnimalAbstrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Animal a = new Animal("Ricardo", "Masculino", "Jegue");
            Zebra z = new Zebra("Zebrinha", "Feminino", "Zebra");
            z.emiteSom();
            z.caminhar();
        }
    }
}