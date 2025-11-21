using workshop.Domain.Interfaces;

namespace workshop.Domain.Media
{
	public class VideoGame: Media, IPlayable
	{
		public string Publisher;
		public int ReleaseYear;
		public string SupportedPlatform;

		public void Play()
		{
			Console.WriteLine("playing");
		}
		public void Complete()
		{
			Console.WriteLine("completed");
		}
	}	
}
