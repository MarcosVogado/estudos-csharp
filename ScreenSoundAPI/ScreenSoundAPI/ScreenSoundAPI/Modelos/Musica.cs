using System.Diagnostics;
using System.Linq.Expressions;
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

    [JsonPropertyName("key")]
    public int? Chave { get; set; }
    public string Tonalidade => Chave switch
    {
        0 => "C",
        1 => "C#",
        2 => "D",
        3 => "D#",
        4 => "E",
        5 => "F",
        6 => "F#",
        7 => "G",
        8 => "G#",
        9 => "A",
        10 => "A#",
        11 => "B",
        _ => "Desconhecida"
    };


    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine("*** Detalhes da Música ***");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração (em segundos): {Duracao /1000}s");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}\n");
    }


}
