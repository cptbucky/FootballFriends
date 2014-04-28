using System.Runtime.Serialization;

namespace Jumpers.Services.DataContracts
{
    [DataContract]
    public class UserRequest
    {
        [DataMember]
        public string Id { get; set; }
    }
}