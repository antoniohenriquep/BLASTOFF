using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Toodoo
{
    public class Questao7
    {

        public List<double> lista = new List<double>();

        public void adicionar(double n)
        {
            lista.Add(n);
        }

        public List<double> Pares()
        {
            List<double> listaPares = new List<double>();
            foreach (var i in lista)
            {
                if(i % 2 == 0)
                    listaPares.Add(i);
            }
            return listaPares;

        }
    }
}
