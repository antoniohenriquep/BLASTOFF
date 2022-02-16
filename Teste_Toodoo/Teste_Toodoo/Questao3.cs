using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Toodoo
{
    public class Questao3
    {

        public double Compara(double a, double b, double c)
        {
            if (a < b && a < c)
                return a;
            else if (b < a && b < c)
                return b;
            else
                return c;
        }
    }
}
