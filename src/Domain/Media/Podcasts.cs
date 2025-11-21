using System;

public class Podcast
{
    public string Host { get; set; }
    public string Guest { get; set; }
    public int EpisodeNumber { get; set; }
    public string Language { get; set; }

    public Podcast(string host, string guest, int episodeNumber, string language)
    {
        Host = host;
        Guest = guest;
        EpisodeNumber = episodeNumber;
        Language = language;
    }

    public void Listen()
    {
        Console.WriteLine($"Listening to episode {EpisodeNumber} with host {Host} and guest {Guest} ({Language}).");
    }

    public void Complete()
    {
        Console.WriteLine($"You have completed episode {EpisodeNumber}.");
    }
}
