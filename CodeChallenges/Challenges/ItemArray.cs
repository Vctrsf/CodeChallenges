using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class ItemArray : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado = GetFirstValue(1);
            Console.WriteLine(resultado);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Create a function that takes an array containing only values of the same type and return the first element.

Examples
GetFirstValue([5, 6, 7]) ➞ 5

GetFirstValue([""Semiramis"", ""Gaia"", ""Hypatia""]) ➞ ""Semiramis""

GetFirstValue([true, false, true]) ➞ true
Notes
The first element in an array always has an index of 0.

input: ");
        }

        public static int GetFirstValue(int num)
        {
            int[] numero = new int[4];
            numero[1] = 1;
            numero[2] = 2;
            numero[3] = 3;

            int resultado = numero[num];
            return resultado;
        }
    }
}
