Podcast podcast1 = new Podcast("Igor 3K", "Flow Podcast");

Episode episode1 = new Episode(2, "The Rise of AI")
{
    DurationInMinutes = 60,
};
Episode episode2 = new Episode(1, "Future of Work")
{
    DurationInMinutes = 45,
};
Episode episode3 = new Episode(3, "Space Exploration")
{
    DurationInMinutes = 50,
};

podcast1.AddEpisode(episode1);
episode1.AddGhest("Elon Musk");
episode1.AddGhest("Sam Altman");

podcast1.AddEpisode(episode2);
episode2.AddGhest("Satya Nadella");

podcast1.AddEpisode(episode3);
episode3.AddGhest("Neil deGrasse Tyson");

podcast1.ShowDetails();

