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
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 4;
            arr[3] = 4;
            arr[4] = 8;
            var resultado1 = Check(arr,11);
            var resultado2 = Check(arr,2);
            var resultado3 = Check(arr,7);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
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
            resultado = arr.Contains(el);
            return resultado;
        }
    }
}
