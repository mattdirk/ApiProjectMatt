using ApiProjectMatt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        public ActionResult<PostModel> PostRequest(string body)
        {
            PostModel model = new PostModel();
            model.body = body;
            DataService service = new DataService();
            //insert the call into the post model table
            PostModel pModel = service.InsertPost(model);

            //take the id of the inserted record and construct the callback link
            pModel.callback = string.Format("http://localhost/callback/{0}", pModel.PostID);
            service.UpdatePost(model);
            //this endpoint is typically something id save to a config table or store in the web/app.config
            service.CallEndpoint("http://example.com/request", body);
            return pModel;
        }

        [HttpPost]
        [Route("/callback/{id}")]
        public ActionResult PostCallback(string id)
        {
            return new StatusCodeResult(204);
        }

        [HttpPut]
        [Route("/callback/{id}")]
        public ActionResult PutCallback(string id)
        {
            return new StatusCodeResult(204);
        }

        [HttpGet]
        [Route("/status/{id}")]
        public ActionResult GetStatus(string id)
        {
            return null;
        }
    }
}
