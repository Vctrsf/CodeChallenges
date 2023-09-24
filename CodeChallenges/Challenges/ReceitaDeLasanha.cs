using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    public class ReceitaDeLasanha : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            int resultado1 = ExpectedMinutesInOven();
            int resultado2 = RemainingMinutesInOven(30);
            int resultado3 = PreparationTimeInMinutes(3);
            int resultado4 = ElapsedTimeInMinutes(3, 20);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
            Console.WriteLine(resultado4);

        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Lucian's girlfriend is on her way home and he hasn't cooked their anniversary dinner!
In this exercise, you're going to write some code to help Lucian cook an exquisite lasagna from his favorite cook book.
You have four tasks, all related to the time spent cooking the lasagna.
Task 1: Define the expected oven time in minutes
Task 2: Calculate the remaining oven time in minutes
Task 3: Calculate the preparation time in minutes
Task 4: Calculate the elapsed time in minutes

input: ");
        }

        public int ExpectedMinutesInOven()
        {
            return 40;
        }

        public int RemainingMinutesInOven(int minutesInOven)
        {
            int resultado = ExpectedMinutesInOven() - minutesInOven;
            return resultado;
        }

        public int PreparationTimeInMinutes(int camadas)
        {
            return camadas * 2;
        }

        public int ElapsedTimeInMinutes(int camadas, int minutesInOven)
        {
            return camadas * 2 + minutesInOven;
        }
    }
}
