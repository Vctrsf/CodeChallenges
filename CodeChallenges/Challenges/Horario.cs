using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class Horario : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado = Convert12hTo24h(1, 7, "AM");
            var resultado2 = Convert12hTo24h(5, 16, "PM");
            var resultado3 = Convert12hTo24h(12, 0, "AM");
            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Converting a 12-hour time like 8:30 am or 8:30 pm to 24-hour time 
(like 0830 or 2030 sounds easy enough, right? Well, let's see if 
you can do it! You will have to define a function, which 
will be given an hour (always in the range of 1 to 12, inclusive), 
a minute (always in the range of 0 to 59, inclusive), and a period 
(either a.m. or p.m.) as input. Your task is to return a four-digit
string that encodes that time in 24-hour time. Notes: 
By convention, noon is 12:00 pm, and midnight is 12:00 am. 
On 12-hours clock, there is no 0 hour, and time just after
midnight is denoted as, for example, 12:15 am. On 24-hour clock, 
this translates to 0015.

input1: 1 7 AM
input2: 5 16 PM
input3: 12 0 AM");

        }

        public static string Convert12hTo24h(int hours, int minutes, string period)
        {
            string horaConvertida = hours.ToString();
            string minutoConvertido = minutes.ToString();

            if (period.ToUpper() == "AM")
            {
                if (hours < 10)
                {
                    horaConvertida = "0" + horaConvertida;
                }

                if (minutes < 10)
                {
                    minutoConvertido= "0" + minutoConvertido;
                }

                if (hours == 12)
                {
                    horaConvertida = "00";
                }

            }
            else
            {
                hours = hours + 12;
                horaConvertida = hours.ToString();
                
                if (minutes < 10)
                {
                    minutoConvertido = "0" + minutoConvertido;
                }

                if (hours == 24)
                {
                    hours = 12;
                    horaConvertida = hours.ToString();
                }

            }

            return horaConvertida + minutoConvertido;
        }   
    }
}
