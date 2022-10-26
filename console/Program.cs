namespace console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            fibonacci fib = new fibonacci();

            int[] seq = fib.Sequence(10);
            Console.WriteLine("[{0}]", string.Join(" |", seq));

            int resposta = 0;

            seq = fib.Sequence(10, 10);
            Console.WriteLine("[{0}]", string.Join(" |", seq));

            while (resposta == 0)
            {
                resposta = fib.TesteNum(int.Parse(Console.ReadLine()));
                Console.WriteLine("[{0}]", resposta);
            }


            Console.Read();
        }
    }
}