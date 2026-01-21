using ScreenSoundAPI.Modelos;

namespace ScreenSoundAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarGeneros(List<Musica> musicas)
    {
        var todosGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();

        Console.WriteLine("Lista de todos os gêneros das músicas disponíveis na API:");

        foreach (var genero in todosGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas.Where(musica => musica.Genero.Contains(genero.ToLower())).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine($"\nLista de artistas do gênero {genero}:");

        foreach (var artista in artistasPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
