using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Toodoo
{
    public class Questao5
    {



        public void Verifica(double a, double b)
        {
            if (a % b == 0)
                Console.WriteLine("São multiplos");
            else
                Console.WriteLine("Não são multiplos");
        }
    }
}
