using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp73_novidades
{
    class DeInstanciaOuEstatico
    {
        public void TestaSobreCarga()
        {
            this.EscreveMensagem(null);
            ResolucaoDeSobrecargas.EscreveMensagem(null);
        }

        public void EscreveMensagem(StringBuilder stringBuilder)
        {
            Console.WriteLine(stringBuilder);
        }

        public static void EscreveMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }


    class MelhoriaEmSobrecargaDeMetodoGenerico
    {
        void TestaMelhoria()
        {
            EscreveMensagem("mensagem", 2);
        }

        public void EscreveMensagem<T>(T objeto, int numero) where T : IDisposable
        {
            Console.WriteLine(objeto);
        }

        public void EscreveMensagem<T>(T objeto, short numero)
        {
            Console.WriteLine(objeto);
        }
    }





}
