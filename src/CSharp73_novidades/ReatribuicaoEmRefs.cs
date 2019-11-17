using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp73_novidades
{
    class ReatribuicaoEmRefs
    {
        public static void TestaRefs()
        {
            var numeros = new [] { 1, 3, 7, 15, 31, 1023, 63, 127, 255, 511 };
            EscreverNumeros(numeros);
        }

        private static int ObterMaiorValor(int[] numeros)
        {
            var maior = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            return maior;
        }

        private static void EscreverNumeros(int[] numeros) =>
            Console.WriteLine(string.Join(", ", numeros));
    }
}
