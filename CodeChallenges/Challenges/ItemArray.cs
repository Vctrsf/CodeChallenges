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
            object[] arr = new object[3];
            arr[0] = "Marcia";
            arr[1] = "Pedro";
            arr[2] = "João";
            var resultado = GetFirstValue(arr);
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

        public static object GetFirstValue(object[] arr)
        {
            return arr[0];
        }
    }
}

