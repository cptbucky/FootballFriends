using System.ServiceModel;
using System.ServiceModel.Web;
using Jumpers.Services.DataContracts;

namespace Jumpers.Services
{
    [ServiceContract]
    public interface IUserService
    {
        //[OperationContract]
        //[WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/GetUser")]
        //UserResponse GetUser(UserRequest request);

        [OperationContract]
        [WebInvoke(UriTemplate = "GetUserById/{id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        UserResponse GetUserById(string id);
    }

    public class UserService : IUserService
    {
        public UserResponse GetUserById(string id)
        {
            return new UserResponse
                {
                    Name = "Test"
                };
        }
    }
}
