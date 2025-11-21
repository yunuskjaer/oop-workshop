using System;

public class App
{
   
    public string Publisher { get; set; }
    public string SupportedPlatform { get; set; }     
    public string SupportedPlatforms { get; set; }   
    public string Version { get; set; }
    public float FileSize { get; set; }              


    public string Title { get; set; }


    public App(string title, string publisher, string supportedPlatform,
               string supportedPlatforms, string version, float fileSize)
    {
        Title = title;
        Publisher = publisher;
        SupportedPlatform = supportedPlatform;
        SupportedPlatforms = supportedPlatforms;
        Version = version;
        FileSize = fileSize;
    }


    public void Execute()
    {
        Console.WriteLine($"Executing {Title} (v{Version}) on {SupportedPlatform}...");
    }
}
