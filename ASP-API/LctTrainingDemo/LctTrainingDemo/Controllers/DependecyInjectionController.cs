using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LctTrainingDemo.Controllers
{
    public class DependecyInjectionController : ApiController
    {
        // GET: api/DependecyInjection
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DependecyInjection/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DependecyInjection
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DependecyInjection/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DependecyInjection/5
        public void Delete(int id)
        {
        }
    }
}
