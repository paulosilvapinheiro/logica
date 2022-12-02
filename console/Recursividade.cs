using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    internal class Recursividade{

        public int Sequencia(int n){

            Console.WriteLine("{0}", n);

            if (n > 10)
            {
                return 0;
            }

            return Sequencia( n + 1 );
        }

        public string Fibonacci(int n_ant, int n_atual, int n_prox){

            string ret = n_prox.ToString();

            n_prox = n_atual + n_ant;
            n_ant = n_atual;
            n_atual = n_prox;

            if (n_atual > 20)
            {
                return "";
            }

            return ret + " - " + Fibonacci( n_ant, n_atual, n_prox );
        }

    }
}