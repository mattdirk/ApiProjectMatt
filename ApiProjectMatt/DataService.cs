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
			try
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
			}catch(Exception ex)
            {
				//log to exceptionlog
				return null;
            }
		}

		public MasterModel InsertIntoMaster(MasterModel model)
        {
			try
			{
				//using (var transaction = _contextClass.Database.BeginTransaction())
				//{
				//	try
				//	{
				//		var masterModel = new MasterModel
				//		{
				//			body = model.body,
				//			callback = model.callback
				//		};

				//		_contextClass.MasterModel.Add(masterModel);
				//		MasterModel tempModel = _contextClass.SaveChanges();

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
				return new MasterModel(DateTime.Now, DateTime.Now, 1, model.body, model.callback);
			}catch(Exception ex)
            {
				//log exception
				return null;
            }
		}

		public bool UpdateMaster(MasterModel model)
		{
			try
			{
				//using (var transaction = _contextClass.Database.BeginTransaction())
				//{
				//	try
				//	{
				//		var existing = _aveContext.MasterModel.Where(x => x.PostID == model.PostID).FirstOrDefault();
				//		_contextClass.SaveChanges();

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
				return true;
			}catch(Exception ex)
            {
				//log exception
				return false;
            }
		}

		public MasterModel GetMaster(int id)
        {
			try
			{
				//using (var transaction = _contextClass.Database.BeginTransaction())
				//{
				//	try
				//	{
				//		var existing = _aveContext.MasterModel.Where(x => x.PostID == id).FirstOrDefault();
				//      return tempModel;
				//	}
				//	catch (Exception ex)
				//	{
				//		//Log the exception
				//		transaction.Rollback();
				//	}
				//}
                return new MasterModel();
            }
            catch (Exception ex) 
			{ 
				//log exception
				return null; 
			} 
		}


	}
}
