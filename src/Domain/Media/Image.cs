namespace workshop.Domain.Media
{
	public class Image: Media
	{
		public string Resolution;
		public string FileFormat;
		public float FileSize;
		public DateTime DateTaken;

		public Image()
		{

		}

		public void Display()
		{
			Console.WriteLine("Displaying image.");
		}
	}
}
