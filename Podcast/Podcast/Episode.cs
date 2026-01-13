class Episode
{
    public List<String> ghestsList = new List<String>();

    public string Title { get; }
    public int EpisodeNumber { get; }
    public int DurationInMinutes { get; set; }
    public string Resume { get; set; }  = string.Empty;

    public Episode(int episodeNumber , String title)
    {
        EpisodeNumber = episodeNumber;
        Title = title;
    }

    public void AddGhest(String guestName)
    {
        ghestsList.Add(guestName);
    }
}