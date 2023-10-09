using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class TamanhoDeUmNumero : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado1 = Length(10);
            var resultado2 = Length(5000);
            var resultado3 = Length(0);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Create a function that takes a number n and returns its length.

Examples
Length(10) ➞ 2

Length(5000) ➞ 4

Length(0) ➞ 1
Notes
N/A

input:");
        }

        public static int Length(int n)
        {
            int resultado = 0;
            string numeroConvertido = n.ToString();
            return resultado + numeroConvertido.Length;
           
        }
    }
}
