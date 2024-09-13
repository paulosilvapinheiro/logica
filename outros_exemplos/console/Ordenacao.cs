using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    internal class Ordenacao
    {
        public int[] OrdenacaoForma_1(int[] inputArray)
        {
            int contadorvolta = 0;
            int contadorif = 0;
            int aux;
            int[] ret = new int[inputArray.Length+3];
            for (int i = 0; i < inputArray.Length; i++)
            {
                int indiceMenor = i;
                for (int j = i; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < inputArray[i])
                    {
                        contadorif++;
                        if (inputArray[j] < inputArray[indiceMenor])
                        {
                            contadorif++;
                            indiceMenor = j;
                        }
                    }
                    contadorvolta++;
                }

                aux = inputArray[indiceMenor];
                inputArray[indiceMenor] = inputArray[i];
                inputArray[i] = aux;
                ret[i] = inputArray[i];
            }

            int faltam=0;
            int test;
            for (int i = 1; i < inputArray.Length; i++)
            {
                //ex: (5 - 1) - (4) = 0 | só ocorrerá 1 ou mais quando tiver pulado um número
                test = (inputArray[i] - 1) - inputArray[i - 1];
                if ( test > 0)
                {
                    faltam += test;
                }
            }

            ret[inputArray.Length] = contadorvolta;
            ret[inputArray.Length+1] = contadorif;
            ret[inputArray.Length + 2] = faltam;
            return ret;
        }

        public int[] OrdenacaoForma_2(int[] inputArray)
        {
            int contadorvolta = 0;
            int contadorif = 0;
            bool exec, seq;
            exec = true;
            seq = true;
            int aux, i, j;

            i = 0;
            j = 1;
            int[] ret = new int[inputArray.Length + 3];
            int faltam = 0;
            int test;
            if (inputArray.Length > 1)
            {
                while (exec)
                {
                    if (inputArray[i] > inputArray[j])
                    {
                        aux = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = aux;
                        seq = false;
                    }
                    ret[i] = inputArray[i];
                    i++;
                    j++;
                    test = (inputArray[i] - 1) - inputArray[i - 1];
                    if (test > 0)
                    {
                        faltam += test;
                    }

                    if (j == inputArray.Length)
                    {
                        contadorif++;
                        if (seq == false)
                        {
                            contadorif++;
                            i = 0;
                            j = 1;
                            faltam = 0;
                            seq = true;
                        }
                        else
                        {
                            ret[i] = inputArray[i];
                            exec = false;
                        }

                    }
                    contadorvolta++;
                }
            }
            ret[inputArray.Length] = contadorvolta;
            ret[inputArray.Length + 1] = contadorif;
            ret[inputArray.Length + 2] = faltam;
            return ret;
        }

        public int[] OrdenacaoInsertMethod(int[] inputArray){

            int[] ret = new int[inputArray.Length + 3];
            int contadorvolta = 0;
            int contadorif = 0;
            int indiceChave;
           
            int j;
            if (inputArray.Length > 1)
            {
                //Método de ordenação
                for (int i = 1; i < inputArray.Length; i++)
                {
                    int chave = inputArray[i];
                    j = i - 1;
                    indiceChave = i;
                    while (j >= 0 && inputArray[j] > chave)
                    {
                        contadorif++;
                        contadorvolta++;
                        inputArray[j + 1] = inputArray[j];

                        j--;
                    }
                    inputArray[j + 1] = chave;

                }
            }

            //Dados de controle
            for (int i = 0; i < inputArray.Length; i++)
            {  
                ret[i] = inputArray[i];
            }
            
            int faltam=0;
            int test;
            for (int i = 1; i < inputArray.Length; i++)
            {
                //ex: (5 - 1) - (4) = 0 | só ocorrerá 1 ou mais quando tiver pulado um número
                test = (inputArray[i] - 1) - inputArray[i - 1];
                if ( test > 0)
                {
                    faltam += test;
                }
            }

            ret[inputArray.Length] = contadorvolta;
            ret[inputArray.Length+1] = contadorif;
            ret[inputArray.Length + 2] = faltam;
            return ret;
        }
    }
}
