using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Controller.Properties
{
    public class ExamenController : ApiController
    {
        // GET: api/Examen
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Examen/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Examen
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Examen/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Examen/5
        public void Delete(int id)
        {
        }
    }
}
