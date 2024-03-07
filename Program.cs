using System;

class Program
{
    static double seguidores = 1000.00; // Saldo inicial

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            MostrarMenu();

            // Ler a opção do usuário
            string escolha = Console.ReadLine();

            switch (escolha.ToLower())
            {
                case "1":
                    funcaoSentinela();
                    break;
                case "2":
                    dadosDeCrescimento();
                    break;
                case "3":
                    saberMais();
                    break;
                case "4":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        Console.WriteLine("Fique ligado em nossa comunidade sempre há atualizações por aqui:)");
    }

    static void MostrarMenu()
    {
        Console.WriteLine("=== NEST a nossa rede VALORANT ===");
        Console.WriteLine("1. Saber mais sobre a função Sentinela");
        Console.WriteLine("2. Dados de crescimento do perfil");
        Console.WriteLine("3. Lendas urbanas sobre Sage");
        Console.WriteLine("4. Sair");
        Console.Write("Escolha uma opção: ");
    }

    static void funcaoSentinela()
    {
        Console.WriteLine($"Ao jogar no time de defensores, os Sentinelas focam em garantir que o inimigo não consiga conquistar o local da bomba. Cruciais para a vitória, mesmo sem acumular uma grande contagem de abates");
    }

    static void saberMais()
    {
        Console.Write("Digite o dia em que nasceu: ");

        Console.WriteLine("Qual o desequilíbrio natural que a Sage causa: ");
        string curso = Console.ReadLine();
        if (curso == "Consegue dar vida a medida que mata")
        {
            Console.WriteLine("Correto");
        }

        else
        {
            Console.WriteLine("Errado");
        }
    }


    static void dadosDeCrescimento()
    {
        Console.Write("Digite o dia em que nasceu: ");
        if (double.TryParse(Console.ReadLine(), out double valorDeposito) && valorDeposito > 0)
        {
            seguidores += valorDeposito;
            Console.WriteLine($"O crescimento semanal é de:: R$ {seguidores:F2}");
        }
        else
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
        }
    }
}
