class Album
{
    private List<Music> musicList = new List<Music>();
    public string Name { get; set; }
    public int TotalDuration => musicList.Sum(m => m.Duration);
    public void AddMusic(Music music)
    {
        musicList.Add(music);
    }

    public void ShowAlbumDetails()
    {
        Console.WriteLine($"Tracklist for album {Name}:");
        Console.WriteLine($"Total Duration: {TotalDuration} seconds.");


        foreach (var music in musicList)
        {
            Console.WriteLine($"Music: {music.Name}");
            Console.WriteLine($"Gender: {music.Gender}");

        }
    }
}
