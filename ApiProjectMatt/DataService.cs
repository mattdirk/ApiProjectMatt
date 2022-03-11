using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectMatt
{
    public class DataService
    {
		public async Task<string> CallEndpoint(string apiAddress, string body)
		{
			HttpResponseMessage response = null;

			using (var client = new HttpClient())
			{
				//setup authentication like a token that will be needed for the call.
				Uri endpoint = new Uri(apiAddress);

				if (body != null)
				{
					var httpContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
					response = await client.PostAsync(endpoint, httpContent).ConfigureAwait(false);
				}

			}

			if (response == null) return null;

			var result = await response.Content.ReadAsStringAsync();
			return result;
		}
	}
}
