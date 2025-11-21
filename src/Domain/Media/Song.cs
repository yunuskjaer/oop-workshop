public class Song
{
    public string Title { get; set; }
    public string Composer { get; set; }
    public string Singer { get; set; }
    public string Filetype { get; set; }


    public Song(string title, string composer, string singer, string filetype)
    {
        Title = title;
        Composer = composer;
        Singer = singer;
        Filetype = filetype;
    }

    public void Play()
    {
        Console.WriteLine($"Playing song: {Title} by {Singer}");
    }

    public void Download()
    {
        Console.WriteLine($"Downloading {Title}.{Filetype}");
    }
}
