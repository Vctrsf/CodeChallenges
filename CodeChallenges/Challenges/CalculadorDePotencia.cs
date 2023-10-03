using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Challenges
{
    internal class CalculadorDePotencia : Challenge
    {
        public override void Execute()
        {
            MostraExplicacao();
            var resultado1 = CircuitPower(230, 10);
            var resultado2 = CircuitPower(125, 84);
            var resultado3 = CircuitPower(316, 18);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
        }

        public void MostraExplicacao()
        {
            Console.WriteLine(@"
Create a function that takes voltage and current and returns the calculated power.

Examples
CircuitPower(230, 10) ➞ 2300

CircuitPower(110, 3) ➞ 330

CircuitPower(480, 20) ➞ 9600
Notes
power is voltage multiplied by current

input:");
        }

        public static int CircuitPower(int voltage, int current)
        {
            var resultado = 0;
            int potencia;
            potencia = voltage * current;
            resultado = potencia;
            return resultado;
        }
    }
}
