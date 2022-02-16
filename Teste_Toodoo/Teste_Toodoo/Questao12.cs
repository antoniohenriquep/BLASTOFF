using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Toodoo
{
    public class Questao12
    {
        List<int> listA = new List<int> { 1, 2, 3, 4 };
        List<int> listB = new List<int> { 1, 2, 5, 8 };


        public List<int> Concatenar()
        {
            List<int> concat = new List<int>();
            concat.AddRange(listA);

            foreach(var i in listB)
            {
                if(!concat.Contains(i))
                    concat.Add(i);
            }

            return concat;
        }
    }
}
