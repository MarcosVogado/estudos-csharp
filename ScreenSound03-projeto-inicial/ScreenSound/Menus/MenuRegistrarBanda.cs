using OpenAI_API;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        var client = new OpenAIAPI(
            Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        var chat = client.Chat.CreateConversation();

        chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo curto. Adote um estilo informal e seja sucinto.");

        string response = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();

        banda.Resumo = response;

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
