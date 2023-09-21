using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class Pilares : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado = Pillars(10, 10, 30);
            Console.WriteLine(resultado);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
There are pillars near the road. The distance between the pillars is the same and the width of the pillars is the same. Your function accepts three arguments:

number of pillars (≥ 1);
distance between pillars (10 - 30 meters);
width of the pillar (10 - 50 centimeters).
Calculate the distance between the first and the last pillar in centimeters (without the width of the first and last pillar).

input:
Pillars: 10
Distance in meters: 12
Width in centimeters: 30");
        }

        int Pillars(int numPill, int dist, int width)
        {
            if (numPill > 1)
            {
                var distanciaEmCentimetros = dist * 100;
                var numeroDeDistancia = numPill - 1;
                return (distanciaEmCentimetros * numeroDeDistancia) + (width * numPill) - (width * 2);
            }
            else
            {
                return 0;
            }
        }
    }
}
