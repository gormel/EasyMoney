using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EasyMoney
{
	public class Downloader
	{
		public string BotUrl { get; set; }
		private HttpClient mClient = new HttpClient();

		public Downloader()
		{
			
		}

		public async Task BeginWork()
		{
			var str = "";
			str = await mClient.GetStringAsync(BotUrl);
			Console.WriteLine("Result: " + str);
		}
	}
}
