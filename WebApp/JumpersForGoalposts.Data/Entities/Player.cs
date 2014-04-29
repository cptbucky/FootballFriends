using System.Runtime.Serialization;
using JumpersForGoalposts.Data.Contracts;

namespace JumpersForGoalposts.Data.Entities
{
    [DataContract]
    internal class Player : IPlayer
    {
        [DataMember]
        public string Name { get; set; }
    }
}