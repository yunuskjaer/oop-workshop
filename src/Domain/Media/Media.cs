using workshop.Domain.Interfaces;

namespace workshop.Domain.Media
{
	public class Media: IRatable, IDownloadable
	{
		public string Genre;
		public string Author;
		public int Year;

		public void Borrow()
		{
			Console.WriteLine("borrowed");
		}

		public void Rate()
		{
			int rating = 10;
			if (rating <= 10 && rating <=0)
			{
				Console.WriteLine($"You rated {rating}/10!");
			}
		}

		public void Download()
		{
			Console.WriteLine("downloading");
		}
	}
}
