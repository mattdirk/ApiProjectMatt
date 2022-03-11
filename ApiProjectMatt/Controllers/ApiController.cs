using ApiProjectMatt.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ApiProjectMatt.Controllers
{
    public class ApiController
    {
        [HttpPost]
        [Route("/request")]
        public ActionResult PostRequest(string body)
        {
            PostModel model = new PostModel();
            model.body = body;
            return null;
        }

        [HttpPost]
        [Route("/callback/{id}")]
        public ActionResult PostCallback(string id)
        {
            return new HttpStatusCodeResult(HttpStatusCode.NoContent); ;
        }

        [HttpPut]
        [Route("/callback/{id}")]
        public ActionResult PutCallback(string id)
        {
            return new HttpStatusCodeResult(HttpStatusCode.NoContent); ;
        }

        [HttpGet]
        [Route("/status/{id}")]
        public ActionResult GetStatus(string id)
        {
            return null;
        }
    }
}
