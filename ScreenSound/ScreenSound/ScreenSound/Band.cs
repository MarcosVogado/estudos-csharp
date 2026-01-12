class Band
{
    public List<Album> albumList { get; set; } = new List<Album>();
    public string Name { get; set; }

    public void AddAlbum(Album album)
    {
        albumList.Add(album);
    }

    public void ShowBandDetails()
    {
        Console.WriteLine("***** Band details *****");

        foreach (Album album in albumList)
        {
            Console.WriteLine($"Album: {album.Name} (Total duration: {album.TotalDuration})");
        }
    }
}