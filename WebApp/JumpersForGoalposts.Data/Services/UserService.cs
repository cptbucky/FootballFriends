using System.ServiceModel;
using System.ServiceModel.Web;
using JumpersForGoalposts.Data.DataContracts;

namespace JumpersForGoalposts.Data.Services
{
    [ServiceContract]
    public interface IUserService
    {
        //[OperationContract]
        //[WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/GetUser")]
        //UserResponse GetUser(UserRequest request);

        [OperationContract]
        [WebInvoke(UriTemplate = "User/{id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        UserResponse User(string id);
    }

    public class UserService : IUserService
    {
        public UserResponse User(string id)
        {
            return new UserResponse
                {
                    Name = "Test"
                };
        }
    }
}
