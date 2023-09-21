using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    public class ConverteAnoIdade : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado = CalcAge(2);
            Console.WriteLine(resultado);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Create a function that takes the age in years and returns the age in days.
Examples
CalcAge(65) ➞ 23725
CalcAge(0) ➞ 0
CalcAge(20) ➞ 7300

Notes
Use 365 days as the length of a year for this challenge.
Ignore leap years and days between last birthday and now.
Expect only positive integer inputs.

input: ");
        }

        public static int CalcAge(int age)
        {
            int resultado = 0;
            int dia = 365;
            
            resultado = age * dia;
            return resultado;

        }
    }
}
