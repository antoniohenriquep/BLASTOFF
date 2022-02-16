using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Toodoo
{
    internal class Questao14
    {


        public void Verifica(string Palavra )
        {
            string inversa;

            Palavra = Palavra.ToUpper();
            inversa = new string(Palavra.Reverse().ToArray());

            if (Palavra.Equals(inversa))
                Console.WriteLine("É palindromo");
            else
                Console.WriteLine("Não é palindromo");
        }
    }
}
