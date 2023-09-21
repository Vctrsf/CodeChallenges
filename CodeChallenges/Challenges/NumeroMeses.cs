using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    public class NumeroMeses : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado1 = MonthName(5);
            var resultado2 = MonthName(7);
            var resultado3 = MonthName(12);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Convert Number to Corresponding Month Name
Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string. For example, if you're given 3 as input, your function should return ""March"", because March is the 3rd month.

Number	Month Name
1	January
2	February
3	March
4	April
5	May
6	June
7	July
8	August
9	September
10	October
11	November
12	December
Examples
MonthName(3) ➞ ""March""

MonthName(12) ➞ ""December""

MonthName(6) ➞ ""June""
Notes
You can expect only integers ranging from 1 to 12 as test input.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

input: ");
        }

        public static string MonthName(int num)
        {
            string resultado;
            string[] meses = new string[13];
            meses[1] = "Janeiro";
            meses[2] = "Fevereiro";
            meses[3] = "Março";
            meses[4] = "Abril";
            meses[5] = "Maio";
            meses[6] = "Junho";
            meses[7] = "Julho";
            meses[8] = "Agosto";
            meses[9] = "Setembro";
            meses[10] = "Outubro";
            meses[11] = "Novembro";
            meses[12] = "Dezembro";

            resultado = meses[num];

            return resultado;
            

            
             
        }
    }
}
