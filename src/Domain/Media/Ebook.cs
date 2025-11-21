using System;

public class Ebook
{
    public string Title { get; set; }          
    public string Author { get; set; }
    public string Language { get; set; }
    public int NumberOfPages { get; set; }
    public int PublicationYear { get; set; }
    public string ISBN { get; set; }

    public Ebook(string title, string author, string language, int numberOfPages, int publicationYear, string isbn)
    {
        Title = title;
        Author = author;
        Language = language;
        NumberOfPages = numberOfPages;
        PublicationYear = publicationYear;
        ISBN = isbn;
    }

    public void View()
    {
        Console.WriteLine($"Viewing info for e-book: {Title} by {Author}");
    
    }

    public void Read()
    {
        Console.WriteLine($"Opening e-book for reading: {Title}");
    }
}
