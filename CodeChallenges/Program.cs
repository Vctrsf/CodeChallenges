using CodeChallenges;
using CodeChallenges.Challenges;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        var Menu = new Menu();
        Menu.MostraMenu();
        var opcaoEscolhida = Console.ReadLine();
        Challenge challenge;
        switch (opcaoEscolhida)
        {
            case "1":
                challenge = new PatasNaFazenda();
                challenge.Execute();
                break;
                case "2":
                challenge = new Pilares();
                challenge.Execute();
                break;
                case "3":
                challenge = new Horario();
                challenge.Execute();
                break;
                case"4":
                challenge = new ConverteAnoIdade();
                challenge.Execute();
                break;
                case"5":
                challenge = new AreaDoTriangulo();
                challenge.Execute();
                break;
                case "6":
                challenge = new RetorneAlgoParaMim();
                challenge.Execute();
                break;
                case "7":
                challenge= new NumeroMeses();
                challenge.Execute();
                break;
                case "8":
                challenge = new QuantidadeVogais();
                challenge.Execute();
                break;
                case "9":
                challenge = new NomeTrocado();
                challenge.Execute();
                break;
                case "10":
                challenge = new MenorQueCem();
                challenge.Execute();
                break;
                case "11":
                challenge = new DivisaoPorCinco();
                challenge.Execute();
                break;
                case "12":
                challenge = new ReceitaDeLasanha();
                challenge.Execute();
                break;
                case "13":
                challenge = new RPG();
                challenge.Execute();
                break;

            default:
                break;
        }
    }
}