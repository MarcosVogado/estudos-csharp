using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public void Sair(Dictionary<string, Banda> bandasRegistradas)
    {
        ExibirTituloDaOpcao("Saindo do Screen Sound 2.0");
        Console.WriteLine("Obrigado por usar o Screen Sound 2.0! Até a próxima!");
    }
}
