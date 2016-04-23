using System;

namespace EasyMoney
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var downloader = new Downloader
				{
					BotUrl = "https://api.telegram.org/bot212221767:AAEqRf9RIFi1yY-u4YWyXz30NLrZZt-NOBE/getMe"
				};
				downloader.BeginWork().ContinueWith(_ => Console.WriteLine("BeginWork completed"));
			}
			catch (Exception e)
			{
				Console.WriteLine("ERROR: " + e.Message);
				throw;
			}
			Console.ReadLine();
		}
	}
}
