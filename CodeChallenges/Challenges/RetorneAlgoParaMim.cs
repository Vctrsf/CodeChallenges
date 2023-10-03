using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    public class RetorneAlgoParaMim : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado = GiveMeSomething("is better than nothing");
            Console.WriteLine(resultado);
        }
    public void MostraExplicacao()
    {
        Console.WriteLine(@"

Write a function that returns the string ""something"" joined with a space "" "" and the given argument a.

Examples
GiveMeSomething(""is better than nothing"") ➞ ""something is better than nothing""
GiveMeSomething(""Bob Jane"") ➞ ""something Bob Jane""
GiveMeSomething(""something"") ➞ ""something something""
Notes
Assume an input is given.

input: ");
    }

        public static string GiveMeSomething(string a)
        {
        string resultado = "something " + a; 
        return resultado;
        }

    }
}
