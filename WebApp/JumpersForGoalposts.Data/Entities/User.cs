using System.Runtime.Serialization;
using JumpersForGoalposts.Data.Contracts;

namespace JumpersForGoalposts.Data.Entities
{
    [DataContract]
    internal class User : IUser
    {
        public User(int id)
        {
            Id = id;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}