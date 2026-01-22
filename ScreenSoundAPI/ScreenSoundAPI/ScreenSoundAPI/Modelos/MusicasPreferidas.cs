using System.Text.Json;

namespace ScreenSoundAPI.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }

    public List<Musica> ListaDeMusicasFavoritas { get; set;  }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicaFavorita(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"\nMúsicas favoritas de {Nome}:");

        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Titulo} por {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"{Nome}_musicas_favoritas.json";

        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine($"\nArquivo {nomeDoArquivo} gerado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}
