using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class BoasVindas : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado1 = HelloName("Victor");
            var resultado2 = HelloName("Luiz");
            var resultado3 = HelloName("Adriana");
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Create a function that takes a name and returns a greeting in the form of a string.

Examples
HelloName(""Gerald"") ➞ ""Hello Gerald!""

HelloName(""Tiffany"") ➞ ""Hello Tiffany!""

HelloName(""Ed"") ➞ ""Hello Ed!""

Notes
The input is always a name (as string).
Don't forget the exclamation mark!
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

input: ");
        }

        public static string HelloName(string name)
        {
            string resultado = "";
            string boasVindas = "Hello" + " " + name + "!";
            resultado = boasVindas;
            return resultado;
        }
    }
}
