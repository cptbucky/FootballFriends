using Jumpers.Data.Contracts;

namespace Jumpers.Services.Models
{
    public class User : IUser
    {
        public int? Id { get; private set; }

        public string Email { get; set; }
    }
}