using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Toodoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================QUESTÃO 01=====================================");

            Questao1 q1 = new Questao1(10, 10, 10, 10, 10);
            Console.WriteLine(q1.Media());



            Console.WriteLine("===========================QUESTÃO 02=====================================");

            Questao2 q2 = new Questao2(17, 2);
            Console.WriteLine("O consumo médio foi de R$" +q2.Consumo());



            Console.WriteLine("===========================QUESTÃO 03=====================================");

            Questao3 q3 = new Questao3();
            Console.WriteLine(q3.Compara(1,2,3));
            Console.WriteLine(q3.Compara(2, 1, 3));
            Console.WriteLine(q3.Compara(2, 3, 1));



            Console.WriteLine("===========================QUESTÃO 04=====================================");

            Questao4 q4 = new Questao4(10);
            Console.WriteLine("O valor da conversão é: " + q4.Converter());



            Console.WriteLine("===========================QUESTÃO 05=====================================");

            Questao5 q5 = new Questao5();
            q5.Verifica(1.5, 0.4);



            Console.WriteLine("===========================QUESTÃO 06=====================================");

            Questao6 q6 = new Questao6();
            System.DateTime date1 = new System.DateTime(2022, 2, 16, 8, 40, 0);
            System.DateTime date2 = new System.DateTime(2022, 2, 16, 10, 15, 0);
            Console.WriteLine("A duração do jogo foi de: " + q6.duracao(date1, date2));



            Console.WriteLine("===========================QUESTÃO 07=====================================");

            Questao7 q7 = new Questao7();
            q7.adicionar(1);
            q7.adicionar(2);
            q7.adicionar(3);
            q7.adicionar(4);
            q7.adicionar(5);
            q7.adicionar(7);
            q7.adicionar(8);
            foreach (var i in q7.Pares())
                Console.WriteLine(i);



            Console.WriteLine("===========================QUESTÃO 08=====================================");

            Questao8 q8 = new Questao8();
            q8.verifica(2);
            q8.verifica(6);



            Console.WriteLine("===========================QUESTÃO 09=====================================");

            Questao9 q9 = new Questao9();
            q9.tabuada(2);



            Console.WriteLine("===========================QUESTÃO 10=====================================");

            Questao10 q10 = new Questao10(14);
            Console.WriteLine("O fatorial de " + q10.Num + " é " + q10.Fatorial());



            Console.WriteLine("===========================QUESTÃO 11=====================================");

            Questao11 q11 = new Questao11();
            foreach(var elemento in q11.Intersec())
                Console.Write(elemento + "\t");
            Console.WriteLine();



            Console.WriteLine("===========================QUESTÃO 12=====================================");

            Questao12 q12 = new Questao12();
            foreach (var elemento in q12.Concatenar())
                Console.Write(elemento + "\t");
            Console.WriteLine();


            Console.WriteLine("===========================QUESTÃO 13=====================================");

            Questao13 q13 = new Questao13();
            q13.MostraMatriz(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } });



            Console.WriteLine("===========================QUESTÃO 14=====================================");

            Questao14 q14 = new Questao14();
            q14.Verifica("Ana");
            q14.Verifica("Antonio");



            Console.ReadLine();

           

          

        }
    }
}
