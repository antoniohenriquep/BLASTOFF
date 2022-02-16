using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Toodoo
{
    public class Questao10 { 

        public Questao10(long num)
        {
        Num = num;
        }

        public long Num;

        public long Fatorial()
        {
            long fatorial = 1;

            for(long i = 1; i <= Num; i++)
                fatorial *= i;

            return fatorial;
        }
    }
}
