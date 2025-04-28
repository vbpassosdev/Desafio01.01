using System.Globalization;

public class ExibirData
{
    public static void Executar()
    {
        Console.WriteLine("\nEscolha uma opção para exibir a data:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data (formato dd/MM/yyyy)");
        Console.WriteLine("3 - Apenas a hora (formato 24 horas)");
        Console.WriteLine("4 - Data com o mês por extenso");
        Console.Write("Digite o número da opção: ");

        string opcaoData = Console.ReadLine();
        DateTime agora = DateTime.Now;

        switch (opcaoData)
        {
            case "1":
                Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", new CultureInfo("pt-BR")));
                break;
            case "2":
                Console.WriteLine(agora.ToString("dd/MM/yyyy"));
                break;
            case "3":
                Console.WriteLine(agora.ToString("HH:mm"));
                break;
            case "4":
                Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}