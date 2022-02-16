using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Toodoo
{
    public class Questao2
    {
        public Questao2(double a, double b)
        {
            A = a;
            B = b;
        }

        public double A, B;

        public double Consumo()
        {
            
            return (A/B);
        }
    }
}
