using workshop.Domain.Interfaces;

namespace workshop.Domain.Media
{
	public class Movie: Media
	{
		public string Director;
		public int ReleaseYear;
		public int Duration;

		public void Watch()
		{
			Console.WriteLine("watching");
		}
	}
}
