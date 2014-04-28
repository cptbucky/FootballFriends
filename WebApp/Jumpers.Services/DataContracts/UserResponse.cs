using System.Runtime.Serialization;

namespace Jumpers.Services.DataContracts
{
    [DataContract]
    public class UserResponse
    {
        [DataMember]
        public string Name { get; set; }
    }
}