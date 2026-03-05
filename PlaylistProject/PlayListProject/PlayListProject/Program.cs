Musica musica1 = new Musica { Titulo = "Bohemian Rhapsody", Artista = "Queen", Duracao = 354 };
Musica musica2 = new Musica { Titulo = "Imagine", Artista = "John Lennon", Duracao = 183 };
Musica musica3 = new Musica { Titulo = "Stairway to Heaven", Artista = "Led Zeppelin", Duracao = 482 };
Musica musica4 = new Musica { Titulo = "Hotel California", Artista = "Eagles", Duracao = 391 };
Musica musica5 = new Musica { Titulo = "Smells Like Teen Spirit", Artista = "Nirvana", Duracao = 301 };

Playlist playlist = new Playlist { Nome = "Rock Classics" };

void ExibirPlaylist(Playlist playlist)
{
    Console.WriteLine("Tocando playlist: " + playlist.Nome);
    foreach(var musica in playlist)
    {
        Console.WriteLine($"Título: {musica.Titulo}, Artista: {musica.Artista}, Duração: {musica.Duracao} segundos");
    }
}
class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }


}

class Playlist
{
    public string Nome { get; set; }
}