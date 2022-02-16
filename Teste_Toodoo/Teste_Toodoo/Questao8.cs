using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Toodoo
{
    public class Questao8
    {
        
        public void verifica(int num)
        {
            int count = 0;
            for(int i = 1; i <= num; i++)
            {

                if(num % i == 0)
                    count++;
            }

            if (count == 2)
                Console.WriteLine("O numero " + num + " é primo");

            else
                Console.WriteLine("O numero " + num + " não é primo");
        }
    }
}
