namespace workshop.Domain.User
{
	public class User
	{
		public string username;
		private string password;

		public User(string user, string pwd)
		{
			this.username = user;
			this.password = pwd;
		}
	}
}
