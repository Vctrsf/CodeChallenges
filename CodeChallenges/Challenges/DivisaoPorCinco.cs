using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class DivisaoPorCinco : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado1 = divisibleByFive(50);
            var resultado2 = divisibleByFive(28);
            var resultado3 = divisibleByFive(14);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Create a function that returns true if an integer is evenly divisible by 5, and false otherwise.

Examples
divisibleByFive(5) ➞ true

divisibleByFive(-55) ➞ true

divisibleByFive(37) ➞ false
Notes
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

input:");
        }

        public static bool divisibleByFive(int n)
        {
            bool resultado;

            if (n % 5 == 0)
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
