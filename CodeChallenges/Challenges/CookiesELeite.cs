using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class CookiesELeite : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado1 = TimeForMilkAndCookies(2077, 12, 31);
            var resultado2 = TimeForMilkAndCookies(1983, 12, 24);
            var resultado3 = TimeForMilkAndCookies(3152, 5, 28);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Christmas Eve is almost upon us, so naturally we need to prepare some milk and cookies for Santa! Create a function that accepts year, month and day as integers and returns true if it's Christmas Eve (December 24th) and false otherwise.

Examples
Date( 2013, 12, 24 ) ➞ true

Date( 2013, 0, 23 ) ➞ false

Date( 3000, 12, 24 ) ➞ true
Notes
All test cases contain valid dates.

input: ");
        }

        public static bool TimeForMilkAndCookies(int year, int month, int day)
        {
            bool resultado;
            if (month == 12 && day == 24) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
