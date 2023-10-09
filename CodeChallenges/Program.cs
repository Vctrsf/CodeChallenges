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
                case "14":
                challenge = new CalculadorDePotencia();
                challenge.Execute();
                break;
                case "15":
                challenge = new BoasVindas();
                challenge.Execute();
                break;
                case "16":
                challenge = new Gols();
                challenge.Execute();
                break;
                case "17":
                challenge = new ItemArray();
                challenge.Execute();
                break;
                case "18":
                challenge = new HorasMinutosEmSegundos();
                challenge.Execute();
                break;
                case "19":
                challenge = new CookiesELeite();
                challenge.Execute();
                break;
                case "20":
                challenge = new Concatenacao();
                challenge.Execute();
                break;
                case "21":
                challenge = new TotalDeCopos();
                challenge.Execute();
                break;
                case "22":
                challenge = new ImparOuPar();
                challenge.Execute();
                break;
                case "23":
                challenge = new QtdeCaractere();
                challenge.Execute();
                break;
                case "24":
                challenge = new TamanhoDeUmNumero();
                challenge.Execute();
                break;
                case "25":
                challenge = new PedacosDeTorta();
                challenge.Execute();
                break;
                

            default:
                break;
        }
    }
}