List<String> listaDasBandas = new List<string> { "Black Alien", "D4vd" };


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
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Ops... Opção invalida!");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda para efetuar o registro: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
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
    Console.WriteLine("=============================");
    Console.WriteLine("Exibindo bandas registradas");
    Console.WriteLine("=============================");
    Console.WriteLine("");

    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione qualquer tecla para retornar para o menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}


ExibirOpcoesDoMenu();