using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Titulo { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; } 

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine("*** Detalhes da Música ***");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração (em segundos): {Duracao /1000}s");
        Console.WriteLine($"Gênero: {Genero}\n");
    }
}
