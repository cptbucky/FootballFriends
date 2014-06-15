using System.Web.Http;
using Jumpers.Data.Contracts;
using Jumpers.Data.Providers;

namespace Jumpers.Services.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/values/5
        public IUser Get(int id)
        {
            return UserProvider.GetUser(id);
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