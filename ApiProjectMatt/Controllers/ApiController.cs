using ApiProjectMatt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ApiProjectMatt.Controllers
{
    public class ApiController
    {
        [HttpPost]
        [Route("/request")]
        public ActionResult<MasterModel> PostRequest(string body)
        {
            MasterModel model = new MasterModel();
            model.body = body;
            DataService service = new DataService();
            //insert the call into the post model table
            MasterModel pModel = service.InsertIntoMaster(model);

            //take the id of the inserted record and construct the callback link
            pModel.callback = string.Format("http://localhost/callback/{0}", pModel.MasterID);
            service.UpdateMaster(model);
            //this endpoint is typically something id save to a config table or store in the web/app.config
            service.CallEndpoint("http://example.com/request", body);
            return pModel;
        }

        [HttpPost]
        [Route("/callback/{id}")]
        public ActionResult<MasterModel> PostCallback(int id)
        {
            DataService service = new DataService();
            service.GetMaster(id);
            return new StatusCodeResult(204);
        }

        [HttpPut]
        [Route("/callback/{id}")]
        public ActionResult PutCallback(int id, string body)
        {
            BodyModel bmodel = JsonConvert.DeserializeObject<BodyModel>(body);

            DataService service = new DataService();
            MasterModel mmodel = service.GetMaster(id);
            mmodel.status = bmodel.status;
            mmodel.detail = bmodel.detail;
            service.UpdateMaster(mmodel);
            return new StatusCodeResult(204);
        }

        [HttpGet]
        [Route("/status/{id}")]
        public ActionResult<BodyModel> GetStatus(int id)
        {
            DataService service = new DataService();
            MasterModel mmodel = service.GetMaster(id);
            BodyModel bmodel = new BodyModel();
            bmodel.status = mmodel.status;
            bmodel.detail = mmodel.detail;
            return bmodel;
        }
    }
}
