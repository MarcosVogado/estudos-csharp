class Band
{
    public List<Album> albumList { get; set; } = new List<Album>();

    public Band(string name)
    {
        Name = name;    
    }

    public string Name { get; }

    public void AddAlbum(Album album)
    {
        albumList.Add(album);
    }

    public void ShowBandDetails()
    {
        Console.WriteLine($"***** details to {Name} *****");

        foreach (Album album in albumList)
        {
            Console.WriteLine($"Album: {album.Name} (Total duration: {album.TotalDuration})");
        }
    }
}