using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Loocey.Seeds.DotNet.Api.Controllers
{

    /// <summary>
    /// Test Api
    /// </summary>
    [RoutePrefix("test")]
    public class TestController : ApiController
    {

        /// <summary>
        /// Returns List of strings
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Returns the input
        /// </summary>
        /// <returns></returns>
        [Route("input/{id}")]
        [HttpGet]
        [ResponseType(typeof(string))]
        public string input(string id)
        {
            return "You entered: "+id;
        }

        /// <summary>
        /// Returns simple string value
        /// </summary>
        /// <returns></returns>
        [Route("getValue")]
        [HttpGet]
        public string getValue()
        {
            return "Simple Value Returned";
        }


        /// <summary>
        /// Adds 2 numbers together
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("addNumbers")]
        [ResponseType(typeof(int))]
        public int addNumbers(int a, int b)
        {
            return a+b;
        }



    }
}
