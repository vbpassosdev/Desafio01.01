public class MensagemBoasVindas
{
    public static void Executar()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
    }
}