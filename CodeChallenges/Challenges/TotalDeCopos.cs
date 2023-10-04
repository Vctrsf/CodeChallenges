using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    public class TotalDeCopos : Challenge

    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado1 = TotalCups(6);
            var resultado2 = TotalCups(12);
            var resultado3 = TotalCups(213);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
For each of the 6 coffee cups I buy, I get a 7th cup free. In total, I get 7 cups. 
Create a function that takes n cups bought and return the total number of cups I would get.

Examples
TotalCups(6) ➞ 7

TotalCups(12) ➞ 14

TotalCups(213) ➞ 248
Notes
Number of cups I bought + number of cups I got for free.
Only valid inputs will be given.

input: ");
        }

        public static int TotalCups(int n)
        {
            int resultado = 0;
            int coposDeGraça = n / 6;
            resultado = n + coposDeGraça;
            
            return resultado;
        }
    }
}
