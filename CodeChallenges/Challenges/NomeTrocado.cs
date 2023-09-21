using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class NomeTrocado : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado = NameShuffle("Victor Souza");
            Console.WriteLine(resultado);
        }
        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.

Examples
NameShuffle(""Donald Trump"") ➞ ""Trump Donald""
NameShuffle(""Rosie O'Donnell"") ➞ ""O'Donnell Rosie""
NameShuffle(""Seymour Butts"") ➞ ""Butts Seymour""

Notes

There will be exactly one space between the first and last name.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

input:");
        }

        public static string NameShuffle(string str)
        {
            string resultado = "";
            string[] nomesSeparados = str.Split(' ');


            resultado = nomesSeparados[1] + " " + nomesSeparados[0];
            return resultado;
        }
    }
}
