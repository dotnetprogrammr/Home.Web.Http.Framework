
namespace Home.Web.Http.Framework.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    public class ExceptionController : ApiController
    {
        // GET: api/Exception
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Exception/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Exception
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Exception/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Exception/5
        public void Delete(int id)
        {
        }
    }
}
