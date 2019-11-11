using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp73_novidades
{
    class AplicacaoWeb
    {
        public static string Porta = "8080";

        public static bool EstaRodandoEmPortaAlta =
            int.TryParse(Porta, out int portaComoInt) && portaComoInt > 1024;

    }



    class ExpressionVariables
    {
        public bool ValidaIdade(string idadeComoTexto) =>
            int.TryParse(idadeComoTexto, out int idade) && idade > 18;

        public static void TestaExpressionVariables()
        {
            var idadeComoTexto = "15";

            
            if(int.TryParse(idadeComoTexto, out int idade) && idade > 18)
            {
                Console.WriteLine("Voce pode entrar");
            }





        }






    }
}
