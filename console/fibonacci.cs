using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    internal class fibonacci
    {
        public int[] Sequence(int tamanhoSequencia)
        {
            int[] sequencia = new int[tamanhoSequencia];
            sequencia[0] = 0;
            sequencia[1] = 1;

            for (int i = 2; i < tamanhoSequencia; i++)
            {

                sequencia[i] = sequencia[i - 1] + sequencia[i - 2];
            }

            return sequencia;
        }

        public int[] Sequence(int inicio, int tamanhoSequencia)
        {
            int anterior = 1;
            int atual = 0;
            int total = 0;

            while (total < inicio)
            {

                total = atual + anterior;
                anterior = atual;
                atual = total;
            }

            int[] sequencia = new int[tamanhoSequencia];

            for (int i = 0; i < tamanhoSequencia; i++)
            {
                sequencia[i] = total;

                total = atual + anterior;
                anterior = atual;
                atual = total;
            }

            return sequencia;
        }

        public int TesteNum(int numTeste)
        {

            int previa = 0;
            int atual = 1;
            int total = 1;

            while (total < numTeste)
            {
                total = atual + previa;
                previa = atual;
                atual = total;
            }

            if (total == numTeste)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public string Fibonacci_Recursivo(int n_ant, int n_atual, int n_prox){

            return new Recursividade().Fibonacci(n_ant,n_atual,n_prox);
        }

        /*
         if(termo<=2)
   numero = termo-1;
  else
   for(var count=3 ; count<=termo ; count++){
    numero = ultimo + penultimo;
    penultimo = ultimo;
    ultimo = numero;
   }
         */
    }
}
