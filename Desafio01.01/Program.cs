class Program
{
    static void Main(string[] args)
    {
        string opcao;

        do
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Mensagem de boas-vindas");
            Console.WriteLine("2 - Concatenar nome e sobrenome");
            Console.WriteLine("3 - Valores (operações)");
            Console.WriteLine("4 - Soma de caracteres");
            Console.WriteLine("5 - Placa do veículo");
            Console.WriteLine("6 - Data");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite o número da opção desejada: ");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":MensagemBoasVindas.Executar(); break;
                case "2":ConcatenarNomeSobrenome.Executar();break;
                case "3":OperacoesValores.Executar();break;
                case "4":ContarCaracteres.Executar();break;
                case "5":PlacaVeiculo.Executar();break;
                case "6":ExibirData.Executar();break;
                case "0":Console.WriteLine("\nPrograma encerrado. Obrigado!");break;
                
                default:
                Console.WriteLine("Opção inválida! Tente novamente.");break;
            }

        } while (opcao != "0"); // Continua até o usuário digitar 0
    }
}
