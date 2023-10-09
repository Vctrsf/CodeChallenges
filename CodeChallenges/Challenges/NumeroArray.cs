using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class NumeroArray : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            //var resultado = Check();
            //Console.WriteLine(resultado);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Write a method to check if an array contains a particular number.

Examples
Check([1, 2, 3, 4, 5], 3) ➞ true

Check([1, 1, 2, 1, 1], 3) ➞ false

Check([5, 5, 5, 6], 5) ➞ true

Check([], 5) ➞ false
Notes
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

input: ");
        }

        public static bool Check(int[] arr, int el)
        {
            bool resultado = true;
            int[] num = arr;
            bool contemNumero = num.Contains(el);
            return contemNumero;
        }
    }
}
