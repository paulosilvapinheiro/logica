﻿namespace console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fibonacci fib = new fibonacci();

            // int[] seq = fib.Sequence(10);
            // Console.WriteLine("[{0}]", string.Join(" |", seq));

            //int resposta = 0;

            // seq = fib.Sequence(0, 3);
            // Console.WriteLine("[{0}]", string.Join(" |", seq));

            //while (resposta == 0)
            //{
            //    resposta = fib.TesteNum(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("[{0}]", resposta);
            //}


            //Console.Read();

            // Ordenacao ord = new Ordenacao();

            // Console.WriteLine("[{0}]", string.Join(" |", ord.OrdenacaoForma_1(new int[] { 10, 6, 3, 2, 8, 7 })));
            // Console.WriteLine("[{0}]", string.Join(" |", ord.OrdenacaoInsertMethod(new int[] { 10, 6, 3, 2, 8, 7 })));
            // Console.WriteLine("[{0}]", string.Join(" |", ord.OrdenacaoForma_2 (new int[] { 10, 6, 3, 2, 8, 7 })));
            // Console.WriteLine("[{0}]", string.Join(" |", ord.OrdenacaoForma_1(new int[] { 1, 10,  2, 4, 5,  9 })));
            // Console.WriteLine("[{0}]", string.Join(" |", ord.OrdenacaoForma_2(new int[] { 1, 10,  2, 4, 5,  9 })));
            // Console.WriteLine("[{0}]", string.Join(" |", ord.OrdenacaoForma_1(new int[] { 1 })));
            // Console.WriteLine("[{0}]", string.Join(" |", ord.OrdenacaoForma_2(new int[] { 1 })));

            Recursividade recur = new Recursividade();
            // recur.Sequencia(9);

            //iniciamos as variaveis n_ant e n_atual invertidas, para compor o inicio da sequencia [ 0 1 1]
            //a partir da 2 volta ela seguiram com os valores condizentes com a nomenclatura da variavel
            Console.WriteLine("{0}", recur.Fibonacci(1,0,0));
            Console.WriteLine("{0}", fib.Fibonacci_Recursivo(1,0,0));
    

        }
    }
}