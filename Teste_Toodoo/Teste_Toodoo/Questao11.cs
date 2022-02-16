using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Toodoo
{
    public class Questao11
    {
        List<int> listA = new List<int> {1,2,3,4};
        List<int> listB = new List<int> {1,2,5,8};

        public List<int> Intersec()
        {
            List<int> intersec = new List<int>();

            foreach (int i in listA) 
            {
                foreach (int j in listB)
                {
                    if (i == j)
                        intersec.Add(j);
                }
            }

            return intersec;
        }

    }
}
