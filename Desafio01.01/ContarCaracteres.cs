public class ContarCaracteres
{
    public static void Executar()
    {
        Console.Write("Digite uma ou mais palavras: ");
        string texto = Console.ReadLine();

        int quantidadeCaracteres = texto.Length;

        Console.WriteLine($"\nO texto digitado possui {quantidadeCaracteres} caracteres.");
    }
}