public class OperacoesValores
{
    public static void Executar()
    {
        Console.Write("Digite o primeiro valor: ");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        double soma = valor1 + valor2;
        double subtracao = valor1 - valor2;
        double multiplicacao = valor1 * valor2;
        double media = (valor1 + valor2) / 2;

        Console.WriteLine($"\nValor 1: {valor1}");
        Console.WriteLine($"Valor 2: {valor2}\n");

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");

        if (valor2 != 0)
        {
            double divisao = valor1 / valor2;
            Console.WriteLine($"Divisão: {divisao}");
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }

        Console.WriteLine($"Média: {media}");
    }
}