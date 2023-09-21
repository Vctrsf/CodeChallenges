using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class QuantidadeVogais : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado = CountVowels("Meu nome é Victor Souza");
            Console.WriteLine(resultado);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Create a function that takes a string and returns the number (count) of vowels contained within it.
Examples
CountVowels(""Celebration"") ➞ 5
CountVowels(""Palm"") ➞ 1
CountVowels(""Prediction"") ➞ 4

Notes
a, e, i, o, u are considered vowels (not y).
All test cases are one word and only contain letters.

input:
Meu nome é Victor Souza");
        }

        public static int CountVowels(string str)
        {
            int resultado = 0;
            char[] arrayDeStr = str.ToCharArray();
            string vogais = "aáãàâAÁÃÀÂeéêEÉÊiíIÍoóõôOÓÔÕuúüUÚÜ";

            foreach (char c in arrayDeStr)
            {
                if (vogais.Contains(c))
                {
                    resultado++;
                }
            }

            return resultado;
        }
    }
}
