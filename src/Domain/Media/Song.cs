using workshop.Domain.Interfaces;

namespace workshop.Domain.Media
{
	public class Song: Media, IPlayable
	{
		public string Composer;
		public string Singer;
		public string FileType;

		public void Play()
		{

		}
	}
}
