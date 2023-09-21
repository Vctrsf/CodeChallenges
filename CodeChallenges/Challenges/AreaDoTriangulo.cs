using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class AreaDoTriangulo : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado = triArea(2, 7);
            Console.WriteLine(resultado);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Write a function that takes the base and height of a triangle and return its area.
Examples
triArea(3, 2) ➞ 3
triArea(7, 4) ➞ 14
triArea(10, 10) ➞ 50

Notes
The area of a triangle is: (base * height) / 2
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

input: ");
        }

        public static int triArea(int b, int h)
        {
            int calculoTriangulo = (b * h) / 2;
            return calculoTriangulo;
        }
    }
}
