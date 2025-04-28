public class ConcatenarNomeSobrenome
{
    public static void Executar()
    {
        Console.Write("Digite seu primeiro nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        string nomeCompleto = nome + " " + sobrenome;
        Console.WriteLine($"Seu nome completo é: {nomeCompleto}");
    }
}