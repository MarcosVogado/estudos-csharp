using ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        Console.WriteLine($"Foram encontradas {musicas.Count} músicas na API.\n");
        musicas[1].ExibirDetalhesDaMusica();
        
        //LinqFilter.FiltrarGenerosDasMusicas(musicas);
        //LinqOrder.ExibirArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "Rock");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "Tyga");
        LinqFilter.FiltrarMusicaPorTonalidade(musicas, "C#");

        //var minhasMusicasPreferidas = new MusicasPreferidas("Marcos");
        //minhasMusicasPreferidas.AdicionarMusicaFavorita(musicas[10]);
        //minhasMusicasPreferidas.AdicionarMusicaFavorita(musicas[20]);
        //minhasMusicasPreferidas.AdicionarMusicaFavorita(musicas[30]);
        //minhasMusicasPreferidas.AdicionarMusicaFavorita(musicas[40]);
        //minhasMusicasPreferidas.AdicionarMusicaFavorita(musicas[50]);
        //minhasMusicasPreferidas.ExibirMusicasFavoritas();
        //minhasMusicasPreferidas.GerarArquivoJson();

        //var minhasSegundasMusicasPreferidas = new MusicasPreferidas("Ana");
        //minhasSegundasMusicasPreferidas.AdicionarMusicaFavorita(musicas[15]);
        //minhasSegundasMusicasPreferidas.AdicionarMusicaFavorita(musicas[25]);
        //minhasSegundasMusicasPreferidas.AdicionarMusicaFavorita(musicas[35]);
        //minhasSegundasMusicasPreferidas.AdicionarMusicaFavorita(musicas[45]);
        //minhasSegundasMusicasPreferidas.AdicionarMusicaFavorita(musicas[55]);
        //minhasSegundasMusicasPreferidas.ExibirMusicasFavoritas();
    }
    catch (Exception excecao)
    {
        Console.WriteLine("Ocorreu um erro ao acessar a API: " + excecao.Message);
    }
}