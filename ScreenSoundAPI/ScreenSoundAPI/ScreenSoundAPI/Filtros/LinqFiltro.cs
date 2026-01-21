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
}
