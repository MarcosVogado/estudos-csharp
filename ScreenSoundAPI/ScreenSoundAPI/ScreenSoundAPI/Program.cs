using ScreenSoundAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //Console.WriteLine($"Foram encontradas {musicas.Count} músicas na API.\n");

        musicas[0].ExibirDetalhesDaMusica();
    }
    catch (Exception excecao)
    {
        Console.WriteLine("Ocorreu um erro ao acessar a API: " + excecao.Message);
    }
}