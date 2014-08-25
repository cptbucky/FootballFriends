using System.Collections.Generic;
using System.Web.Http;
using Jumpers.Data.Contracts;

namespace Jumpers.Services.Controllers
{
    public class SquadController : ApiController
    {
        // GET api/values/5
        //public IEnumerable<IPlayer> Get(int id)
        //{
        //    return SquadProvider.GetSquad();
        //}

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