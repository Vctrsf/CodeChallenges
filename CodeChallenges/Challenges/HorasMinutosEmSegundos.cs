using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class HorasMinutosEmSegundos : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado = Convert(1, 3);
            Console.WriteLine(resultado);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Write a function that takes two integers (hours, minutes), converts them to seconds, and adds them.

Examples
Convert(1, 3) ➞ 3780

Convert(2, 0) ➞ 7200

Convert(0, 0) ➞ 0
Notes
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

input: ");
        }

        public static int Convert(int hours, int minutes)
        {
            int resultado = 0;

            hours = hours * 3600;
            minutes = minutes * 60;
            resultado = hours + minutes;
            return resultado;
        }
    }
}
