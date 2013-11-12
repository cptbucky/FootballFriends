using System.Runtime.Serialization;

namespace JumpersForGoalposts.Data.DataContracts
{
    [DataContract]
    public class UserRequest
    {
        [DataMember]
        public string Id { get; set; }
    }
}