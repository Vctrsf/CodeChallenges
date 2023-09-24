using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class MenorQueCem : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado1 = lessThan100(55, 49);
            var resultado2 = lessThan100(10, 71);
            var resultado3 = lessThan100(28, 60);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.

Examples
lessThan100(22, 15) ➞ true
// 22 + 15 = 37

lessThan100(83, 34) ➞ false
// 83 + 34 = 117

lessThan100(3, 77) ➞ true

input: ");
        }

        public static bool lessThan100(int a, int b)
        {
            bool resultado;
            if (a + b < 100)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }
    }
}
