public class PlacaVeiculo
{
    public static void Executar()
    {
        Console.Write("Digite a placa do veículo (padrão antigo - 3 letras e 4 números): ");
        string placa = Console.ReadLine().ToUpper(); // Transformar em maiúsculo para facilitar

        if (EhPlacaValida(placa))
        {
            Console.WriteLine("Placa válida!");
        }
        else
        {
            Console.WriteLine("Placa inválida!");
        }
    }

    private static bool EhPlacaValida(string placa)
    {
        if (placa.Length != 7)
            return false;

        for (int i = 0; i < 3; i++) // Verifica se os 3 primeiros são letras
        {
            if (!char.IsLetter(placa[i]))
                return false;
        }

        for (int i = 3; i < 7; i++) // Verifica se os 4 últimos são números
        {
            if (!char.IsDigit(placa[i]))
                return false;
        }

        return true;
    }
}