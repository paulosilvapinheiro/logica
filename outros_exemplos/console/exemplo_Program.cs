/*using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {*/
            //1 - Identificar o menor numero inteiro diferente de zero. Se não houver, retornar -1.
            //int[] A = new int[] { 0, 1, 1, 1, 0, 1, 1, 1, 0, 1 };
            //int[] AA = new int[] { 0, 0 };
            //int[] AAA = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0 };

            //Console.WriteLine(menorInteiro(A).ToString());
            //Console.WriteLine(menorInteiro(AA).ToString());
            //Console.WriteLine(menorInteiro(AAA).ToString());

            //2 - Dado um dia da semana e uma quantidade de dias a percorrer, determine em qual dia da semana vai cair após percorrer esses dias.
            //Console.WriteLine(diaSemana("Wed", 2));
            //Console.WriteLine(diaSemana("Sat", 23));

            //3 - Criar função que dado um valor N, gera um array de tamanho N de numeros aleatórios. Criar uma segunda função que identifica o menor valor inteiro dentro do array criado.
            //int tamanhoArray = 6;
            //int[] array = criaArray(tamanhoArray);


            //int[] A = new int[] { -1, 2, 0, 7, -7, 6 };
            //int menorValor = find_min(A);
            //Console.WriteLine(menorValor);

            //menorValor = find_min(array);
            //Console.WriteLine(array.ToString());
            //Console.WriteLine(menorValor);

            //4 - Dado um comando, validar: Name: string entre 3 e 10 caracteres; Count: um numero entre 10 e 100; Help: retornar 0.
            // Para parametro VALIDO, retornar 1. Para parametro INVALIDO, retornar -1.
           /* string[] argumentos = { "--name", "SOME_NAME", "--count", "10" };
            var val = new ValidateArguments();
            var result = val.Validate(argumentos);
            Console.WriteLine(result);*/

            //string[] argumentos = { "--name", "SOME_NAME", "--count", "10" };
 /*           string[] argumentos2 = { "--name", "George Henrique da SIlveira", "--count", "10" };
            string[] argumentos3 = { "--name", "SOME_NAME", "--count", "150" };
            string[] argumentos4 = { "--help", "--name", "SOME_NAME", "--count", "100" };

            Console.WriteLine(new ValidateArguments().Validate(argumentos));
            Console.WriteLine(new ValidateArguments().Validate(argumentos2));
            Console.WriteLine(new ValidateArguments().Validate(argumentos3));
            Console.WriteLine(new ValidateArguments().Validate(argumentos4));

        }

        internal class ValidateArguments
        {
            internal int Validate(string[] args)
            {
                bool help = false;
                bool valid = false;
                Int32 number;

                for (int i = 0; i < args.Length; i++)
                {
                    switch (args[i].ToUpper().ToString())
                    {
                        case "--HELP":
                            help = true;
                            i--;
                            break;
                        case "--COUNT":
                            if (Int32.TryParse(args[i + 1], out number))
                                if (number >= 10 && number <= 100)
                                    valid = true;
                                else
                                    return -1;
                            else
                                return -1;
                            break;
                        case "--NAME":
                            if (args[i+1].ToString().Length >= 3 && args[i+1].ToString().Length <= 10)
                                valid = true;
                            else
                                return -1;
                            break;
                        default:
                            return -1;
                    }

                    i++;
                }

                if (help && args.Length == 1)
                    return 1;
                else if (help && valid)
                    return 1;
                else if (!help && valid)
                    return 0;
                else
                    return -1;
            }
        }

        private static int[] criaArray(int N)
        {
            int[] A = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = new Random().Next(-1000, 1000);
            }

            return A;
        }

        private static int find_min(int[] A)
        {
            int ans = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < ans)
                {
                    ans = A[i];
                }
            }
            return ans;
        }

        private static string diaSemana(string S, int K)
        {
            string[] dias = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            int diaInicial = Array.IndexOf(dias, S);

            K += diaInicial;

            int moduloDia = K % 7;

            return dias[moduloDia];
        }

        private static int menorInteiro(int[] A)
        {
            int n = A.Length;
            int i = n - 1;
            int result = -1;
            int k = 0, maximal = 0;

            while (i >= 0)
            {
                if (A[i] == 1)
                {
                    k = k + 1;
                    if (k >= maximal)
                    {
                        maximal = k;
                        result = i;
                    }
                }
                else
                    k = 0;
                i = i - 1;
            }
            if (A[i + 1] == 1 && k + 1 > maximal)
                result = 0;

            return result;
        }
    }
}
*/