using ScreenSound.Modelos;
using ScreenSound.Menus;

Banda metalica = new Banda("Metallica");
metalica.AdicionarNota(new Avaliacao(10));
metalica.AdicionarNota(new Avaliacao(8));
metalica.AdicionarNota(new Avaliacao(9));

Banda beatles = new Banda("The Beatles");
beatles.AdicionarNota(new Avaliacao(10));
beatles.AdicionarNota(new Avaliacao(3));

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(metalica.Nome, metalica);
bandasRegistradas.Add(beatles.Nome, beatles);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
    } else
    {
        Console.WriteLine("Opção inválida!");
    }

        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                MenuRegistrarBanda menuRegistrarBanda = new MenuRegistrarBanda();
                menuRegistrarBanda.RegistrarBanda(bandasRegistradas);
                ExibirOpcoesDoMenu();
                break;
            case 2:
                MenuRegistrarAlbum menuRegistrarAlbum = new MenuRegistrarAlbum();
                menuRegistrarAlbum.RegistrarAlbum(bandasRegistradas);
                ExibirOpcoesDoMenu();
                break;
            case 3:
                MenuMostrarBandas menuMostrarBandas = new MenuMostrarBandas();
                menuMostrarBandas.MostrarBandasRegistradas(bandasRegistradas);
                ExibirOpcoesDoMenu();
                break;
            case 4:
                MenuAvaliarBanda menuBandasRegistradas = new MenuAvaliarBanda();
                menuBandasRegistradas.Executar(bandasRegistradas);
                ExibirOpcoesDoMenu();
                break;
            case 5:
                MenuExibirDetalhes menuDetalhes = new MenuExibirDetalhes();
                menuDetalhes.Executar(bandasRegistradas);
                ExibirOpcoesDoMenu();
                break;
            case -1:
                MenuSair menuSair = new MenuSair();
                menuSair.Sair(bandasRegistradas);
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
}

ExibirOpcoesDoMenu();