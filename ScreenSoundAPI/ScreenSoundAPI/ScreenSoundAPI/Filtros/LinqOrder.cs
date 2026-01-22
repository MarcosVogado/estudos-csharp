using ScreenSoundAPI.Modelos;

namespace ScreenSoundAPI.Filtros;

internal class LinqOrder
{
    public static void ExibirArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy
        (
            musica => musica.Artista
        ).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine("Lista de todos os artistas ordenados alfabeticamente:");

        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
