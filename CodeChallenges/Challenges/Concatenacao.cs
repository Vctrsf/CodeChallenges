using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    public class Concatenacao : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado = ConcatName("Victor", "Souza");
            Console.WriteLine(resultado);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Given two strings, firstName and lastName, return a single string in the format ""last, first"".

Examples
ConcatName(""First"", ""Last"") ➞ ""Last, First""

ConcatName(""John"", ""Doe"") ➞ ""Doe, John""

ConcatName(""Mary"", ""Jane"") ➞ ""Jane, Mary""
Notes
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

input: ");
        }

        public static string ConcatName(string firstName, string lastName)
        {
            string resultado = " ";
            resultado = lastName + "," + " " + firstName;
            return resultado;
        }
    }
}
