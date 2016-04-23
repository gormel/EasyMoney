using System;
using System.Collections.Generic;
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
			var result = await CallMethod("getMe", new Dictionary<string, string>());
			Console.WriteLine("Result: " + await result.Content.ReadAsStringAsync());
		}

		private async Task Request(Dictionary<string, string> parameters)
		{
			
		}

		private async Task<HttpResponseMessage> CallMethod(string methodName, IDictionary<string, string> parameters)
		{
			return await mClient.PostAsync(BotUrl + "/" + methodName, new FormUrlEncodedContent(parameters));
		}
	}
}
