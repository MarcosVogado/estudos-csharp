using System.Collections;

Musica musica1 = new Musica { Titulo = "Bohemian Rhapsody", Artista = "Queen", Duracao = 354 };
Musica musica2 = new Musica { Titulo = "Imagine", Artista = "John Lennon", Duracao = 183 };
Musica musica3 = new Musica { Titulo = "Stairway to Heaven", Artista = "Led Zeppelin", Duracao = 482 };
Musica musica4 = new Musica { Titulo = "Hotel California", Artista = "Eagles", Duracao = 391 };
Musica musica5 = new Musica { Titulo = "Smells Like Teen Spirit", Artista = "Nirvana", Duracao = 301 };
Musica musica6 = new Musica { Titulo = "Enter Sandman", Artista = "Metallica", Duracao = 331 };
Musica musica7 = new Musica { Titulo = "Nothing Else Matters", Artista = "Metallica", Duracao = 388 };
Musica musica8 = new Musica { Titulo = "Unforgiven II", Artista = "Metallica", Duracao = 380 };

Playlist playlist = new Playlist { Nome = "Rock Classics" };

playlist.Add(musica1);
playlist.Add(musica2);
playlist.Add(musica3);
playlist.Add(musica4);
playlist.Add(musica5);
playlist.Add(musica5);
playlist.Add(musica6);
playlist.Add(musica7);
playlist.Add(musica8);


Playlist metallica = new Playlist { Nome = "Metallica" };
metallica.Add(musica6);
metallica.Add(musica7);
metallica.Add(musica8);


playlist.ExibirPlaylist();
metallica.ExibirPlaylist();

//playlist.OrdenarPorDuracao();
//Console.WriteLine("\n-> Playlist ordenada por duração:\n");
//playlist.ExibirPlaylist();
//playlist.OrdenarPorArtista();
//Console.WriteLine("\n-> Playlist ordenada por artista:\n");
//playlist.ExibirPlaylist();

playlist.ExibirMusicaAleatoria();

ExibirMaisTocadas(metallica, playlist);

void ExibirMaisTocadas(Playlist p1, Playlist p2)
{
    // Musica (chave/key), Contagem/count (valor/value)
    Dictionary<Musica, int> ranking = new();

    foreach (var musica in p1)
    {
        ranking.Add(musica, 1);
    }

    foreach (var musica in p2)
    {
        if (ranking.TryGetValue(musica, out int contagem))
        {
            ranking[musica] = contagem++;
        }
        else
        {
            ranking[musica] = 1;
        }
    }
    
    List<KeyValuePair<Musica, int>> top = new(ranking);
    top.Sort(new PorContagem());

    Console.WriteLine("\n-> Top 3 Músicas mais tocadas:");
    int contador = 0;
    foreach (var par in top)
    {
        Console.WriteLine($"{contador++}. {par.Key.Titulo} - {par.Key.Artista} (Tocada {par.Value} vezes)");
        contador++;
        if (contador > 3) break;
    }
}

class PorContagem : IComparer<KeyValuePair<Musica, int>>
{
    public int Compare(KeyValuePair<Musica, int> x, KeyValuePair<Musica, int> y)
    {
        return y.Value.CompareTo(x.Value);
    }
}

class PorArtista : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Artista.CompareTo(y.Artista);
    }
}

class PorTitulo : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Titulo.CompareTo(y.Titulo);
    }
}

class Musica : IComparable
{
    public string Titulo { get; set; } = string.Empty;
    public string Artista { get; set; } = string.Empty;
    public int Duracao { get; set; }

    public int CompareTo(object? other)
    {
        if (other is null) return 1;

        if (other is Musica outraMusica)
        {
            return Duracao.CompareTo(outraMusica.Duracao);
        }

        throw new ArgumentException("Objeto inválido para comparação.");
    }

    public override bool Equals(object? obj)
    {
        if(obj is null) return false;
        if(obj is Musica outraMusica) 
            return this.Titulo.Equals(outraMusica.Titulo) && this.Artista.Equals(outraMusica.Artista);
        
        return false;
    }

    public override int GetHashCode()
    {
        return this.Titulo.GetHashCode() ^ this.Artista.GetHashCode();
    }
}

class Playlist : ICollection<Musica>
{
    private readonly HashSet<Musica> set = new();
    private readonly List<Musica> lista = new();

    public string Nome { get; set; } = string.Empty;
    public int Count => lista.Count;
    public bool IsReadOnly => false;

    public void Add(Musica musica)
    {
        if (set.Add(musica))
        {
            lista.Add(musica);
        }
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

    public bool Remove(Musica item)
    {
        return lista.Remove(item);
    }

    public IEnumerator<Musica> GetEnumerator()
    {
        return lista.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void OrdenarPorDuracao()
    {
        lista.Sort();
    }

    public void OrdenarPorArtista()
    {
        lista.Sort(new PorArtista());
    }

    public Musica? ObterPeloTitulo(string titulo)
    {
        foreach (var musica in lista)
        {
            if (musica.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
            {
                return musica;
            }
        }

        return null;
    }

    public Musica? ObterMusicaAleatoria()
    {
        if (lista.Count == 0)
            return null;

        var random = new Random();
        var indiceAleatorio = random.Next(lista.Count);
        return lista[indiceAleatorio];
    }

    public void ExibirPlaylist()
    {
        Console.WriteLine($"-> Tocando playlist: {Nome}");

        foreach (var musica in lista)
        {
            Console.WriteLine($"Título: {musica.Titulo}, Artista: {musica.Artista}, Duração: {musica.Duracao} segundos");
        }
    }

    public void ExibirMusicaAleatoria()
    {
        var musicaAleatoria = ObterMusicaAleatoria();

        if (musicaAleatoria is not null)
        {
            Console.WriteLine($"\n-> Música aleatória: {musicaAleatoria.Titulo}");
        }
        else
        {
            Console.WriteLine("\n-> A playlist está vazia.");
        }
    }
}