using System.Collections.Generic;
using System.Web.Http;

namespace SqlSignalR.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly JobInfoRepository objRepo = new JobInfoRepository();
        // GET api/values

        public IEnumerable<Info> Get()
        {
            return objRepo.GetData();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}