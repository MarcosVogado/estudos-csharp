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
}
