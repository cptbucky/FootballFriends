using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Jumpers.Data.Contracts;
using Jumpers.Services.Models;

namespace Jumpers.Services.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/users/5
        public IUser GetUser(int id)
        {
            //var user = UserProvider.GetUser(id);

            //if (user == null)
            //{
            //    throw new HttpResponseException(HttpStatusCode.NotFound);
            //}

            return null;
        }

        // POST api/users
        public HttpResponseMessage Post(User newUser)
        {
            //IUser createdUser = Data.Repositories.UserRepository.Create(newUser);

            //var response = Request.CreateResponse<IUser>(HttpStatusCode.Created, createdUser);

            //string uri = Url.Link("DefaultApi", new { id = createdUser.Id });
            
            //response.Headers.Location = new Uri(uri);

            return null;
        }

        // PUT api/users/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/users/5
        public void Delete(int id)
        {
        }
    }
}