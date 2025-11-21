namespace workshop.Domain.Media
{
	public class Ebook
	{
    		public string Title;         
    		public string Author; 
    		public string Language;
    		public int NumberOfPages;
    		public int PublicationYear;
    		public string ISBN;

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
}
