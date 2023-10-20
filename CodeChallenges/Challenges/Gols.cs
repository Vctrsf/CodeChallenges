using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class Gols : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado1 = FootballPoints(3, 4, 2);
            var resultado2 = FootballPoints(5, 0, 2);
            var resultado3 = FootballPoints(0, 0, 1);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Create a function that takes the number of wins, draws and losses and calculates the number of points 
a football team has obtained so far.

wins get 3 points
draws get 1 point
losses get 0 points
Examples
FootballPoints(3, 4, 2) ➞ 13

FootballPoints(5, 0, 2) ➞ 15

FootballPoints(0, 0, 1) ➞ 0
Notes
Inputs will be numbers greater than or equal to 0.

input: ");
        }

        public static int FootballPoints(int wins, int draws, int losses)
        {
            int resultado = 0;
            int vitorias = wins * 3;
            int empates = draws;
            int derrotas = losses - losses;
            resultado = vitorias + empates + derrotas;
            return resultado;
        }
    }
}
