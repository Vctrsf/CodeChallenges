using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    public class PatasNaFazenda : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado = Animals(10, 7, 8);
            Console.WriteLine(resultado);

        }
        public void MostraExplicacao()
        {
            Console.WriteLine(@"
In this challenge, a farmer is asking you to tell him how many legs can be counted among all his animals. The farmer breeds three species:
chickens = 2 legs
cows = 4 legs
pigs = 4 legs
The farmer has counted his animals and he gives you a subtotal for each species. You have to implement a function that returns the total number of legs of all the animals.

input:
Number of chickens: 10
Number of cows: 7
Number of pigs: 8

Total of legs: ");
        }

        public int Animals(int chickens, int cows, int pigs)
        {
            return (chickens * 2) + (cows * 4) + (pigs * 4);
        }

    }
}
