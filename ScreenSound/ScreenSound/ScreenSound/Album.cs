class Album
{
    private List<Music> musicList = new List<Music>();
    public string Name { get; set; }
    public int TotalDuration { get; set; }

    public void AddMusic(Music music)
    {
        musicList.Add(music);
    }
}
