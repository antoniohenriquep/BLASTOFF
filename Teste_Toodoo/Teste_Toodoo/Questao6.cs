using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Toodoo
{
    public class Questao6
    {
        public TimeSpan duracao(DateTime a, DateTime b)
        {
            System.TimeSpan diferenca = b.Subtract(a);
            return diferenca;
        }
    }
}
