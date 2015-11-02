using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDocGenSwagger.Controllers
{
    public class ValuesController : ApiController
    {
        /// <summary>
        /// This is the first Get documentation
        /// </summary>
        /// <returns>Enumerable string</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// This is the first Get documentation
        /// </summary>
        /// <returns>Enumerable string</returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}