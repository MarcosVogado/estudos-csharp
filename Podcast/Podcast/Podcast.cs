class Podcast
{
    List<Episode> episodesList = new List<Episode>();

    public string Host { get; }
    public string Name { get; }
    public int episodesCount;

    public Podcast(string host, string name)
    {
        Host = host;
        Name = name;
    }

    public void AddEpisode(Episode episode)
    {
        episodesList.Add(episode);
    }

    public void ShowDetails()
    {
        episodesCount = episodesList.Count;
        Console.WriteLine($"Podcast: {Name} by {Host}");
        Console.WriteLine($"*Episodes:   ({episodesCount})");

        foreach (Episode episode in episodesList.OrderBy(e => e.EpisodeNumber))
        {
            episode.Resume = $"   Episode {episode.EpisodeNumber}: {episode.Title} - Duration: {episode.DurationInMinutes} mins";

            Console.WriteLine(episode.Resume);
            Console.WriteLine("     > Guests:");

            foreach (string guest in episode.ghestsList)
            {
                Console.WriteLine($"      - {guest}");
            }
        }
    }
}