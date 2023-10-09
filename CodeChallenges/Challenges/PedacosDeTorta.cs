using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class PedacosDeTorta : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado1 = EqualSlices(11, 5, 2);
            var resultado2 = EqualSlices(11, 5, 3);
            var resultado3 = EqualSlices(8, 3, 2);
            var resultado4 = EqualSlices(8, 3, 3);
            var resultado5 = EqualSlices(24, 12, 2);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
            Console.WriteLine(resultado4);
            Console.WriteLine(resultado5);

        }
        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Create a function that determines whether or not it's possible to split a pie fairly given these three parameters:

Total number of slices.
Number of recipients.
How many slices each person gets.
The function will be in this form:

EqualSlices(total slices, no. recipients, slices each)
Examples
EqualSlices(11, 5, 2) ➞ true
// 5 people x 2 slices each = 10 slices < 11 slices 

EqualSlices(11, 5, 3) ➞ false
// 5 people x 3 slices each = 15 slices > 11 slices

EqualSlices(8, 3, 2) ➞ true

EqualSlices(8, 3, 3) ➞ false

EqualSlices(24, 12, 2) ➞ true
Notes
Return (trivially) true if there are zero people.
It's fine not to use the entire pie.
All test parameters are integers.
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

input: ");
        }
        public static bool EqualSlices(int total, int people, int each)
        {
            bool resultado = true;
            if(people * each <= total)
            {
                return true;
            }
            else
            {
                return false;
            }

            return resultado;
            
        }

        

    }

}
