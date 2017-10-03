using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Loocey.Seeds.DotNet.Api.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        [HttpGet]
        [AcceptVerbs("GET")]
        [Route("index")]
        [ResponseType(typeof(string))]
        public string index()
        {

            return "Welcome to Loocey Seed Project";
        }



    }
}
