using System.Runtime.Serialization;

namespace JumpersForGoalposts.Data.DataContracts
{
    [DataContract]
    public class UserResponse
    {
        [DataMember]
        public string Name { get; set; }
    }
}