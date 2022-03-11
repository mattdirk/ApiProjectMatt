using ApiProjectMatt.Models;
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
		//instantiate a copy of the context class which will contain virtual definitions of the models defined.
		//ContextClass _contextClass = new ContextClass();

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

		public PostModel InsertPost(PostModel model)
        {
			//using (var transaction = _contextClass.Database.BeginTransaction())
			//{
			//	try
			//	{
			//		var postModel = new PostModel
			//		{
			//			body = model.body,
			//			callback = model.callback
			//		};

			//		_contextClass.PostModel.Add(postModel);
			//		PostModel tempModel = _contextClass.SaveChanges();

			//		transaction.Commit();
			//		//return the inserted object
			//      return tempModel;
			//	}
			//	catch (Exception ex)
			//	{
			//		//Log the exception
			//		transaction.Rollback();
			//	}
			//}
			return new PostModel(;
		}
	}
}
