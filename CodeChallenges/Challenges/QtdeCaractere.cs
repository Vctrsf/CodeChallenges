using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class QtdeCaractere : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado1 = Comp("ab", "cd");
            var resultado2 = Comp("vi", "tor");
            var resultado3 = Comp("Olá", "Mundo!");
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Create a function that takes two strings as arguments and return either true or false depending on whether the total number of characters in the first string is equal to the total number of characters in the second string.

Examples
Comp(""AB"", ""CD"") ➞ true

Comp(""ABC"", ""DE"") ➞ false

Comp(""hello"", ""edabit"") ➞ false
Notes
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

input");
        }

        public static bool Comp(string str1, string str2)
        {
            bool resultado;
            if(str1.Length == str2.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
