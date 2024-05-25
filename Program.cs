

void ExibirLogo ()
{
    Console.WriteLine(@"

██████████████████████████████████████████████████
█─▄▄▄▄█▄─█─▄█▄─▄█▄─▀█▄─▄█▀▀▀▀▀███▀▄─██▄─▄▄─█▄─▄▄─█
█▄▄▄▄─██─▄▀███─███─█▄▀─██████████─▀─███─▄▄▄██─▄▄▄█
▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▀▄▄▄▀▀▄▄▀▀▀▀▀▀▀▀▄▄▀▄▄▀▄▄▄▀▀▀▄▄▄▀▀▀
    ");
    Console.WriteLine("O seu aplicativo de dicas de SkinCare.");
}

void ExibirMenu ()
{
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("\n\nMENU INICIAL");
    Console.WriteLine("1. Começar informando suas queixas.");
    Console.WriteLine("2. Buscar produto pela função.");
    Console.WriteLine("3. Buscar produtos recomendados por marca.");
    Console.WriteLine("4. Buscar produtos por faixa de preço.");
    Console.WriteLine("5. Buscar produtos por média de avaliação.");
    Console.WriteLine("\nDigite a opção escolhida: ");
    string opcaoEscolhida = Console.ReadLine()!;
}

ExibirLogo();
ExibirMenu();