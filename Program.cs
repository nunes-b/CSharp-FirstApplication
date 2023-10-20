//List<String> listaDasBandas = new List<string> { "Black Alien", "D4vd" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int> { 10, 8});

void ExibirLogo()
{
string  mensagemDeBoasVindas =(@"
░██████╗░░█████╗░██╗░░░░░░█████╗░  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝░██╔══██╗██║░░░░░██╔══██╗  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
██║░░██╗░███████║██║░░░░░██║░░██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
██║░░╚██╗██╔══██║██║░░░░░██║░░██║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
╚██████╔╝██║░░██║███████╗╚█████╔╝  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
░╚═════╝░╚═╝░░╚═╝╚══════╝░╚════╝░  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine(mensagemDeBoasVindas);

}


void ExibirOpcoesDoMenu()
{
    ExibirLogo();

    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\n Digite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 0: Console.WriteLine("Obrigado por utilizar nossos serviços.");
            break;
        case 1: RegistrarBandas();
            break;
        case 2: ListarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: CalculaMediaDaBanda();
            break;
        default: Console.WriteLine("Ops... Opção invalida!");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda para efetuar o registro: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ListarBandas() {
    Console.Clear();
    //   for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //   Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    ExibirTituloDaOpcao("Exibindo bandas registradas");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nPressione qualquer tecla para retornar para o menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void    ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(quantidadeDeLetras, '=');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
}

void AvaliarBanda()
{

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
            Console.Write($"Qual a nota que {nomeDaBanda} merece? ");
            int nota = int.Parse(Console.ReadLine()!);
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.WriteLine($"A {nota} foi registrada com sucesso para a {nomeDaBanda}!\n");
            Thread.Sleep(1000);
            Console.Clear();
            ExibirOpcoesDoMenu();
            }
        else
            {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada.");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal!");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
            }
}

void CalculaMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Verifique as medias da sua banda preferida!");
    Console.Write("\nDigite o nome da banda que deseja verificar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (string.IsNullOrEmpty(nomeDaBanda))
    {
        Console.WriteLine("Nome da banda não pode estar vazio.");
    }

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> mediaDasbandas = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA nota da banda {nomeDaBanda} é {mediaDasbandas.Average()}.");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }


}

ExibirOpcoesDoMenu();