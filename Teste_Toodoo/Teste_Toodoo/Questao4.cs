using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Toodoo
{
    public class Questao4
    {
        public Questao4(double t)
        {
            T = t;
        }

        double T;

        public double Converter()
        {
            return ((9*T)/5)+32;
        }
    }
}
