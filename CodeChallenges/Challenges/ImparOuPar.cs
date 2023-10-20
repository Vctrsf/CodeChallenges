using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class ImparOuPar : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado1 = IsEvenOrOdd(3);
            var resultado2 = IsEvenOrOdd(146);
            var resultado3 = IsEvenOrOdd(-19);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Create a function that takes a number as an argument and returns ""even"" for even numbers and""odd"" for odd numbers.

Examples
isEvenOrOdd(3) ➞ ""odd""

isEvenOrOdd(146) ➞ ""even""

isEvenOrOdd(19) ➞ ""odd""
Notes
Dont forget to return the result.
Input will always be a valid integer.
Expect negative integers (whole numbers).
Tests are case sensitive (return ""even"" or ""odd"" in lowercase).

input: ");
        }

        public static string IsEvenOrOdd(int num)
        {
            string resultado = " ";
            if (num % 2 == 0)
            {
                resultado = "even";
            }
            else
            {
                    resultado = "odd";
            }
                return resultado;           
        }
    }
}
