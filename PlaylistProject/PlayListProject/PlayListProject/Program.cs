using System.Collections;

Musica musica1 = new Musica { Titulo = "Bohemian Rhapsody", Artista = "Queen", Duracao = 354 };
Musica musica2 = new Musica { Titulo = "Imagine", Artista = "John Lennon", Duracao = 183 };
Musica musica3 = new Musica { Titulo = "Stairway to Heaven", Artista = "Led Zeppelin", Duracao = 482 };
Musica musica4 = new Musica { Titulo = "Hotel California", Artista = "Eagles", Duracao = 391 };
Musica musica5 = new Musica { Titulo = "Smells Like Teen Spirit", Artista = "Nirvana", Duracao = 301 };

Playlist playlist = new Playlist { Nome = "Rock Classics" };
playlist.Add(musica1);
playlist.Add(musica2);
playlist.Add(musica3);
playlist.Add(musica4);
playlist.Add(musica5);

var musicaEncontrada = playlist.ObterPeloTitulo("Hotel California");

if (musicaEncontrada is not null)
{
    Console.WriteLine($"\nMúsica encontrada: Título: {musicaEncontrada.Titulo}, Artista: {musicaEncontrada.Artista}, Duração: {musicaEncontrada.Duracao} segundos\n");
    playlist.Remove(musicaEncontrada);
}
else
{
    Console.WriteLine("\nMúsica não encontrada.");
}

ExibirPlaylist(playlist);

void ExibirPlaylist(Playlist playlist)
    {
        Console.WriteLine("-> Tocando playlist: " + playlist.Nome);
        foreach (var musica in playlist)
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

class Playlist : ICollection<Musica>
{
    private List<Musica> lista = new List<Musica>();
    public string Nome { get; set; }

    public int Count => lista.Count;

    public bool IsReadOnly => false;

    public void Add(Musica musica)
    {
        lista.Add(musica);
    }

    public void Clear()
    {
        lista.Clear();
    }

    public bool Contains(Musica item)
    {
        return lista.Contains(item);
    }

    public void CopyTo(Musica[] array, int arrayIndex)
    {
        lista.CopyTo(array, arrayIndex);
    }

    public IEnumerator<Musica> GetEnumerator()
    {
        return lista.GetEnumerator();
    }

    public bool Remove(Musica item)
    {
        return lista.Remove(item);
    }

    internal Musica? ObterPeloTitulo(string titulo)
    {
        foreach (var musica in lista) { if (musica.Titulo.Equals(titulo)) return musica; }
        return null;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}