using System;

namespace decomporNumero
{
    public static class Calculo
    {
        const int MAX_SIZE = 15000;

        static bool IsNumeroPrimo(long numero)
        {
            bool bPrimo = true;
            long fator = numero / 2;

            int i = 0;
            for (i = 2; i <= fator; i++)
            {
                if ((numero % i) == 0)
                    bPrimo = false;
            }
            return bPrimo;
        }
        static public long GetFatoresPrimos(long numero, out long[] arrResultado)
        {
            int contador = 0;
            int[] vetor = new int[MAX_SIZE];
            arrResultado = new long[MAX_SIZE];
            int i = 0;
            int indice = 0;
            for (i = 2; i <= numero; i++)
            {
                if (IsNumeroPrimo(i) == true)
                    vetor[contador++] = i;
            }
            while (true)
            {
                if (IsNumeroPrimo(numero) == true)
                {
                    arrResultado[indice++] = numero;
                    break;
                }
                for (i = contador - 1; i >= 0; i--)
                {
                    if ((numero % vetor[i]) == 0)
                    {
                        arrResultado[indice++] = vetor[i];
                        numero = numero / vetor[i];
                        break;
                    }
                }
            }
            return indice;
        }
    }
}
